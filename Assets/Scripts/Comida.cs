using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Comida : MonoBehaviour
{
    public float hambre = 100f;
    public Image barra;    
    [SerializeField] private GameObject menuPerder;
    public GameManager gameManager;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (hambre <= 0)
        {
            Time.timeScale = 0f;
            menuPerder.SetActive(true);

        }
        else if (hambre > 0 && gameManager.estaPausado == false)
        {
            Time.timeScale = 1f;
            hambre -= 10f * Time.deltaTime;
        }

        barra.fillAmount = hambre / 100f;
    }

    private void OnCollisionEnter(Collision col){
        if(col.gameObject.tag == "Drop"){
            Destroy(col.gameObject);
            Puntos();
        }
    }
    
    public void Puntos(){
        hambre += 30f;
    }
}
