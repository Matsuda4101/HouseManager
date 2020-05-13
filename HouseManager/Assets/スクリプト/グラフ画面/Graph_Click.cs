using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Graph_Click : MonoBehaviour
{
    public GameObject E;
    public GameObject W;
    public GameObject G;
    public Text text;

    string graph;

    // Start is called before the first frame update
    void Start()
    {
        graph = PlayerPrefs.GetString("Graph_Choice", "E");

        if (graph == "E")
        {
            E.SetActive(true);
            W.SetActive(false);
            G.SetActive(false);
            text.text = "電気代グラフ";
        }
        if (graph == "W")
        {
            E.SetActive(false);
            W.SetActive(true);
            G.SetActive(false);
            text.text = "水道代グラフ";
        }
        if (graph == "G")
        {
            E.SetActive(false);
            W.SetActive(false);
            G.SetActive(true);
            text.text = "ガス代グラフ";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void E_Click()
    {
        E.SetActive(true);
        W.SetActive(false);
        G.SetActive(false);
        text.text = "電気代グラフ";
        PlayerPrefs.SetString("Graph_Choice", "E");
    }

    public void W_Click()
    {
        E.SetActive(false);
        W.SetActive(true);
        G.SetActive(false);
        text.text = "水道代グラフ";
        PlayerPrefs.SetString("Graph_Choice", "W");
    }

    public void G_Click()
    {
        E.SetActive(false);
        W.SetActive(false);
        G.SetActive(true);
        text.text = "ガス代グラフ";
        PlayerPrefs.SetString("Graph_Choice", "G");
    }
}
