using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public bool hasEstaca = false;
    public bool hasVersiculo = false;
    public bool hasAguaBendita = false;
    public void AgarrarEstaca()
    {
        Debug.Log("Agarr� la estaca");
        hasEstaca = true;
        Debug.Log($"{hasEstaca} :D");
    }

    public void AgarrarAguaBendita()
    {
        Debug.Log("Agarr� el agua Bendita");
        hasEstaca = true;
        Debug.Log($"{hasAguaBendita} :D");
    }

    public void AgarrarVersiculo()
    {
        Debug.Log("Agarr� el vers�culo");
        hasEstaca = true;
        Debug.Log($"{hasVersiculo} :D");
    }

    //public void AgarrarAbrirComputadora()
    //{
    //    Debug.Log("Agarr� la estaca");
    //    hasEstaca = true;
    //    Debug.Log($"{hasEstaca} :D");
    //}

    private void Update()
    {
        if (AllElementos())
        {
            Debug.Log("Por ahora no pasa nada");
        }    
    }

    public Boolean AllElementos()
    {
        return this.hasAguaBendita && this.hasEstaca && this.hasVersiculo;
    }
}
