﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Select_to_Water : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Next()
    {
        SceneManager.LoadScene("WaterScene");
    }

    public void Return()
    {
        SceneManager.LoadScene("SelectScene");
    }
}
