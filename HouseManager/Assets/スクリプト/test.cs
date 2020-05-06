using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject line;
    // Start is called before the first frame update
    void Start()
    {
        LineRenderer LR = this.gameObject.GetComponent<LineRenderer>();

        LR.startWidth = 0.1f;
        LR.endWidth = 0.1f;
        LR.SetVertexCount(12);
        LR.SetPosition(0, new Vector3(-2, 0, 0));
        LR.SetPosition(1, new Vector3(-1.8f, 1, 0));
        LR.SetPosition(2, new Vector3(-1.6f, 0, 0));
        LR.SetPosition(3, new Vector3(-1.4f, 1, 0));
        LR.SetPosition(4, new Vector3(-1.2f, 0, 0));
        LR.SetPosition(5, new Vector3(-1.0f, 1, 0));
        LR.SetPosition(6, new Vector3(-0.8f, 0, 0));
        LR.SetPosition(7, new Vector3(-0.6f, 1, 0));
        LR.SetPosition(8, new Vector3(-0.4f, 0, 0));
        LR.SetPosition(9, new Vector3(-0.2f, 1, 0));
        LR.SetPosition(10, new Vector3(0, 0, 0));
        LR.SetPosition(11, new Vector3(0.2f, 1, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
