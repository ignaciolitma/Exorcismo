using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements.Platform.Editor;
using UnityEngine.SceneManagement;

public class CloseReload : MonoBehaviour
{
    // Start is called before the first frame update
    public void RecargarJuego()
    {
        SceneManager.LoadScene("PlaceHolder");
    } 
    
    public void VolverMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void CerrarJuego()
    {
        Application.Quit();
    }

}
