using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InventoryManager : MonoBehaviour
{
    public bool hasEstaca = false;
    public bool hasVersiculo = false;
    public bool hasAguaBendita = false;
    public List<Int32> ids = new List<int>();
    public void AgarrarEstaca(GameObject biblia)
    {
        Debug.Log("Agarré la estaca");
        hasEstaca = true;
        Destroy(biblia);
        CheckAllObject();
    }

    public void AgarrarAguaBendita(GameObject muerto)
    {
        Debug.Log("Agarré awa");
        hasAguaBendita= true;
        Destroy(muerto);
        CheckAllObject();
    }

    public void AgarrarVersiculo(GameObject versiculo)
    {
        Debug.Log("Agarré versiculo");
        hasVersiculo = true;
        Destroy(versiculo);
        CheckAllObject();
    }

    private void CheckAllObject()
    {
        if (AllElementos())
            IrA("Exorcismo");
    }

    public void DestruirBasura(GameObject objeto)
    {
        Destroy(objeto);
    }

    public void UsarObjeto(GameObject objeto)
    {
        switch (objeto.name)
        {
            case "AguaBendita":
                ids.Add((int)MyEnum.AguaBendita);
                break;
            case "Biblia":
                ids.Add((int)MyEnum.Biblia);
                break;
            case "Versiculo":
                ids.Add((int)MyEnum.Versiculo);
                break;
        }
        
        Debug.Log($"{ids}");
        Destroy(objeto);
        OrdenCorrecto(ids);
    }

    public Boolean AllElementos()
    {
        return this.hasAguaBendita && this.hasEstaca && this.hasVersiculo;
    }

    public void OrdenCorrecto(List<Int32> ids)
    {
        if(ids.First() == 0 && ids.Last() == 2)
        {
            IrA("Ganar");
        }
        else if(ids.Count() == 3)
        {
            IrA("Perder");
        }

    }

    private static void IrA(string escena)
    {
        SceneManager.LoadScene(escena);
    }

    enum MyEnum
    {
        AguaBendita,
        Biblia,
        Versiculo,
    }
}
