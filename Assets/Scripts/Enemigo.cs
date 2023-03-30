using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public GameObject drop;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Instantiate(drop, gameObject.transform.position, Quaternion.identity);
    }
}
