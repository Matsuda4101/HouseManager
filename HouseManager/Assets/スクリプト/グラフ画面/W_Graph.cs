using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W_Graph : MonoBehaviour
{
    public GameObject WGraph;
    float number;
    int month = 1;

    float x = -2;

    // Start is called before the first frame update
    void Start()
    {
        LineRenderer W_Line = WGraph.GetComponent<LineRenderer>();

        W_Line.SetVertexCount(12);

        for (int i = 0; i < 12; i++)
        {
            number = PlayerPrefs.GetInt("W_" + month.ToString());
            W_Line.SetPosition(i, new Vector3(x, number / 4000 - 3, 0));

            W_Line.startWidth = 0.1f;
            W_Line.endWidth = 0.1f;

            month++;
            x = x + 0.3636f;
            Debug.Log(x);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
