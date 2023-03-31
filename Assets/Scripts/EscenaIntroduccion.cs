using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscenaIntroduccion : MonoBehaviour
{
    public GameObject primerPanel;
    public GameObject escenaIntroduccion;
    // Start is called before the first frame update
    
    public void IniciarIntroduccion()
    {
        primerPanel.SetActive(false);
        escenaIntroduccion.SetActive(true);
    }

    public void Jugar()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Salir()
    {
        Application.Quit();
    }
}
