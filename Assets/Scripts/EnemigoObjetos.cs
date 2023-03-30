using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoObjetos : MonoBehaviour
{
    public GameObject dropeo;
    public float puntos;

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player"){
            Destroy(gameObject);
            Instantiate(dropeo, gameObject.transform.position, Quaternion.identity);
        }
        
    }
}
