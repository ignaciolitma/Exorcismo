using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    private bool hasEstaca = false;
    public void AgarrarEstaca()
    {
        Debug.Log("Agarr� la estaca");
        hasEstaca = true;
        Debug.Log($"{hasEstaca} :D");
    }
}
