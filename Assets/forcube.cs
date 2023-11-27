using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class forcube : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sphere;
    public Text x;
    public Button B;
    public int c;
    private bool active = true;

    void Start()
    {
        c = 0;
    }
    public void FixedUndate()   
    {
        c++;
        active = !active;
        sphere.SetActive(active);
        x.text = c.ToString();
    }
    // Update is called once per frame

    void Update()
    {

    }
}
