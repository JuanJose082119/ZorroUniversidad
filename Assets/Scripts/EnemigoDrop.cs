using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoDrop : MonoBehaviour
{
    public GameObject drop;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Instantiate(drop, gameObject.transform.position, Quaternion.identity);
    }
}
