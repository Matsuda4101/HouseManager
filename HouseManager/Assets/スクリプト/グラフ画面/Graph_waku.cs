using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Graph_waku : MonoBehaviour
{
    LineRenderer G_W;
    public GameObject G;

    // Start is called before the first frame update
    void Start()
    {
        G_W = G.GetComponent<LineRenderer>();
        G_W.SetVertexCount(5);

        G_W.SetPosition(0, new Vector3(-2, -3, 0));
        G_W.SetPosition(1, new Vector3(-2, 2, 0));
        G_W.SetPosition(2, new Vector3(2, 2, 0));
        G_W.SetPosition(3, new Vector3(2, -3, 0));
        G_W.SetPosition(4, new Vector3(-2, -3, 0));

        G_W.startWidth = 0.05f;
        G_W.endWidth = 0.05f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
