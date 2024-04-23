using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawLine : MonoBehaviour
{
    public LineRenderer line;
    public GameObject Follower;
    private Vector2 GetWorldCoordinate(Vector3 ObjectPosition)
    {
        Vector2 ObjectPoint = new Vector3(ObjectPosition.x, ObjectPosition.y, 1);
        return Camera.main.ScreenToWorldPoint(ObjectPoint);
    }
    // Start is called before the first frame update
    void Start()
    {
        line.startWidth = 0.2f;
        line.endWidth = 0.2f;
        line.positionCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 currentPoint = GetWorldCoordinate(Follower.transform.position);
        line.positionCount++;
        line.SetPosition(line.positionCount - 1, currentPoint);
    }
}
