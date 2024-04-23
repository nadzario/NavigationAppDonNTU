using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Work : MonoBehaviour
{
    [SerializeField]
    public List<Node> m_Nodes = new List<Node>();
    [SerializeField]
    protected Graph MyGraph;
    [SerializeField]
    protected GameObject Graph_Object;
    [SerializeField]
    protected Follower m_Follower;
    [SerializeField]
    protected GameObject m_Follower_Object;
    protected Node m_From;
    protected Node m_To;
    protected Path m_Path = new Path();
    public InputField from;
    [SerializeField] 
    public InputField to;
	string input_from_text, input_to_text;
    


    public virtual List<Node> nodes
    {
        get
        {
            return m_Nodes;
        }
    }

    

    public Node FindStart(string a) 
    {
        for (int i = 0; i < m_Nodes.Count; i++) 
        {
            if (m_Nodes[i].NodeName == a) 
            {
                return m_Nodes[i];
            }
        }
        return null;
    }

    public Node FindEnd(string b)
    {
        for (int i = 0; i < m_Nodes.Count; i++)
        {
            if (m_Nodes[i].NodeName == b)
            {
                return m_Nodes[i];
            }
        }
        return null;
    }


    

   

 
    public void Upd()
    {
        
        if (Graph_Object.activeSelf)
        {
            if (m_Follower_Object.activeSelf)
            {
                if (input_from_text != from.text || input_to_text != to.text)
                {

                    input_from_text = from.text;
                    input_to_text = to.text;
                    m_From = FindStart(input_from_text);
                    m_To = FindEnd(input_to_text);
                    m_Path = MyGraph.GetShortestPath(m_From, m_To);
                    if (m_Follower != null)
                    {
                        m_Follower.Follow(m_Path);
                    }
                    Debug.Log(m_Path);








                }
            }
        }
        
    }
}
