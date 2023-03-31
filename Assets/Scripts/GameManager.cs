using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject menuPausa;
    public bool estaPausado;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            PausarTodo();
        }
    }

    public void PausarTodo()
    {
        estaPausado = !estaPausado;

        if(estaPausado)
        {
            Debug.Log("Esta Pausado");
            Time.timeScale= 0f;
            menuPausa.SetActive(true);
        }
        else
        {
            Debug.Log("No Esta Pausado");
            Time.timeScale= 1f;
            menuPausa.SetActive(false);
        }
    }
}
