using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The Follower.
/// </summary>
[ExecuteInEditMode]
public class Follower : MonoBehaviour
{

    [SerializeField]
    protected Graph m_Graph;
    [SerializeField]
    protected Node m_Start;
    [SerializeField]
    protected Node m_End;
    [SerializeField]
    protected float m_Speed = 1f;
    [SerializeField]
    protected LineRenderer ln;
    protected Path m_Path = new Path();
    protected Node m_Current;

    

    /// <summary>
    /// Follow the specified path.
    /// </summary>
    /// <param name="path">Path.</param>
    public void Follow(Path path)
    {
        StopCoroutine("FollowPath");
        m_Path = path;
        transform.position = m_Path.nodes[0].transform.position;
        ln.positionCount = 0;
        ln.SetPosition(0, m_Path.nodes[0].transform.position);
        StartCoroutine("FollowPath");
    }

    /// <summary>
    /// Following the path.
    /// </summary>
    /// <returns>The path.</returns>
    IEnumerator FollowPath()
    {
#if UNITY_EDITOR
    UnityEditor.EditorApplication.update += Update;
#endif
        var e = m_Path.nodes.GetEnumerator();
        while (e.MoveNext())
        {
            m_Current = e.Current;

            // Wait until we reach the current target node and then go to next node
            yield return new WaitUntil(() =>
            {
                return transform.position == m_Current.transform.position;
            });

            // Add the current node's position to the Line Renderer's position array
            Vector2 currentPoint = GetWorldCoordinate(m_Current.transform.position);
            ln.positionCount++;
            ln.SetPosition(ln.positionCount - 1, currentPoint);
        }
        m_Current = null;
#if UNITY_EDITOR
    UnityEditor.EditorApplication.update -= Update;
#endif
    }

    private Vector2 GetWorldCoordinate(Vector3 objectPosition) 
    {
        Vector2 objectPoint = new Vector3(objectPosition.x, objectPosition.y, 1);
        return objectPoint;
    }

    void Start() 
    {
        ln.startWidth = 0.02f;
        ln.endWidth = 0.02f;
        ln.positionCount = 0;
    }

    void Update()
    {
        if (m_Current != null)
        {
            Vector2 currentPoint = GetWorldCoordinate(m_Current.transform.position);
            ln.positionCount++;
            ln.SetPosition(ln.positionCount - 1, currentPoint);
            transform.position = Vector3.MoveTowards(transform.position, m_Current.transform.position, m_Speed);
        }
    }



}
