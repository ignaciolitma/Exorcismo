using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    public void ClickReaction(InventoryManager inventoryManager)
    {
        inventoryManager.AgarrarEstaca();
    }
}
