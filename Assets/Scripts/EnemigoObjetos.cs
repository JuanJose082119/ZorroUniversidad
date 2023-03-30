using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoObjetos : MonoBehaviour
{
    public GameObject dropeo;
    public float puntos;
    public float vida;

    void Start(){
        vida = 30;
    }

    void Update(){
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player"){
            if(vida <= 0){                
                Destroy(gameObject);
                Instantiate(dropeo, gameObject.transform.position, Quaternion.identity);
            }
        }
        
    }
}
