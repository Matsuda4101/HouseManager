using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_to_Edit : MonoBehaviour
{
    string graph;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        graph = PlayerPrefs.GetString("Graph_Choice","E");

        if (graph == "E")
        {
            SceneManager.LoadScene("ElectricalScene");
        }else if (graph == "W")
        {
            SceneManager.LoadScene("WaterScene");
        }else if (graph == "G")
        {
            SceneManager.LoadScene("GasScene");
        }
    }
}
