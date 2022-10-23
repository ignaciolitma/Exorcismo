using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    private bool hasEstaca = false;
    public void AgarrarEstaca()
    {
        Debug.Log("Agarré la estaca");
        hasEstaca = true;
        Debug.Log($"{hasEstaca} :D");
    }
}
