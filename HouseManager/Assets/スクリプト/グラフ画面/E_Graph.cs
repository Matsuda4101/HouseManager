using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Graph : MonoBehaviour
{
    public GameObject EGraph;
    float number;
    int month=1;

    float x = -2;

    // Start is called before the first frame update
    void Start()
    {
        LineRenderer E_Line = EGraph.GetComponent<LineRenderer>();

        E_Line.SetVertexCount(12);
        

        for (int i = 0; i < 12; i++)
        {
            number = PlayerPrefs.GetInt("E_"+month.ToString());
            E_Line.SetPosition(i,new Vector3(x,number/3000-3,0));

            E_Line.startWidth = 0.1f;
            E_Line.endWidth = 0.1f;

            month++;
            x=x+0.3636f;
            Debug.Log(x);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
