using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Comida : MonoBehaviour
{
    public float hambre = 100f;
    public Image barra;    
    public EnemigoObjetos enem;
    [SerializeField] private GameObject menuPerder;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(hambre);
        if(hambre <= 0){
            Debug.Log("Perdiste");
            Time.timeScale = 0f;
            menuPerder.SetActive(true);

        } else if(hambre > 0){
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
        hambre += enem.puntos;
    }
}
