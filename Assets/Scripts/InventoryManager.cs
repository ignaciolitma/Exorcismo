using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InventoryManager : MonoBehaviour
{
    public bool hasEstaca = false;
    public bool hasVersiculo = false;
    public bool hasAguaBendita = false;
    public void AgarrarEstaca()
    {
        Debug.Log("Agarré la estaca");
        hasEstaca = true;
        Debug.Log($"{hasEstaca} :D");
    }

    public void AgarrarAguaBendita()
    {
        hasEstaca = true;
    }

    public void AgarrarVersiculo()
    {
        hasEstaca = true;
    }

    //public void AgarrarAbrirComputadora()
    //{
    //    Debug.Log("Agarré la estaca");
    //    hasEstaca = true;
    //    Debug.Log($"{hasEstaca} :D");
    //}

    private void Update()
    {
        if (AllElementos())
        {
            SceneManager.LoadScene("Exorcismo");
        }    
    }

    public Boolean AllElementos()
    {
        return this.hasAguaBendita && this.hasEstaca && this.hasVersiculo;
    }
}
