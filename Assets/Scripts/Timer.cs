using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        reloj.text = TimeSpan.FromSeconds(timer).ToString(@"m\:ss");
        if(timer <= 0f)
        {
            SceneManager.LoadScene("Perder");
        }
    }
}
