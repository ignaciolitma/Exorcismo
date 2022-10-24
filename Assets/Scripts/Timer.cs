using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text reloj;
    public float timer = 180;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        reloj.text = timer.ToString();
        if(timer <= 0f)
        {
            SceneManager.LoadScene("Perder");
        }
    }
}
