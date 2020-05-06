using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Water_Main : MonoBehaviour
{
    GameObject parent;

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
        parent = transform.parent.gameObject;
        PlayerPrefs.SetString("manager", "W_" + parent.name);
        SceneManager.LoadScene("W_EditScene");
    }
}
