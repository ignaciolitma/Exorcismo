using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public bool hasEstaca = false;
    public bool hasVersiculo = false;
    public bool hasAguaBendita = false;
    public void AgarrarEstaca(GameObject biblia)
    {
        Debug.Log("Agarré la estaca");
        hasEstaca = true;
        Destroy(biblia);
    }

    public void AgarrarAguaBendita(GameObject muerto)
    {
        Debug.Log("Agarré awa");
        hasAguaBendita= true;
        Destroy(muerto);
    }

    public void AgarrarVersiculo(GameObject computadora)
    {
        hasVersiculo = true;
        Destroy(computadora);
    }

    public void DestruirBasura(GameObject objeto)
    {
        Destroy(objeto);
    }

    //public void AgarrarAbrirComputadora()
    //{
    //    Debug.Log("Agarré la estaca");
    //    hasEstaca = true;
    //    Debug.Log($"{hasEstaca} :D");
    //}



    public Boolean AllElementos()
    {
        return this.hasAguaBendita && this.hasEstaca && this.hasVersiculo;
    }
}
