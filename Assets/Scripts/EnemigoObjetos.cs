using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoObjetos : MonoBehaviour
{
    public GameObject dropeo;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Instantiate(dropeo, gameObject.transform.position, Quaternion.identity);
    }
}
