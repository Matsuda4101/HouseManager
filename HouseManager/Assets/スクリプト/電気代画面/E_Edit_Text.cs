using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class E_Edit_Text : MonoBehaviour
{
    public InputField inputfield;
    string month;

    // Start is called before the first frame update
    void Start()
    {
        month=PlayerPrefs.GetString("manager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Next()
    {
        PlayerPrefs.SetInt(month, int.Parse(inputfield.text));
        SceneManager.LoadScene("ElectricalScene");
    } 

    public void Back()
    {
        SceneManager.LoadScene("ElectricalScene");
    }
}
