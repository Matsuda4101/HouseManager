﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class G_Money_Get : MonoBehaviour
{
    GameObject parent;
    public Text text;
    int month;

    // Start is called before the first frame update
    void Start()
    {
        parent = transform.parent.gameObject;
        month = PlayerPrefs.GetInt("G_" + parent.name.ToString(), 0);
        text.text = month.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
