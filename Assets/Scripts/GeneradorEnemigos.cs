using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorEnemigos : MonoBehaviour
{
    [SerializeField] private GameObject enemigoPrefab;
    [SerializeField] private float enemigoIntervalo;

    private void Start()
    {
        StartCoroutine(GenEnemigos(enemigoIntervalo, enemigoPrefab));
    }

    private IEnumerator GenEnemigos(float intervalo, GameObject enemigo)
    {
        yield return new WaitForSeconds(intervalo);
        GameObject nuevoEnemigo = Instantiate(enemigo, this.gameObject.transform.position, Quaternion.identity);
        StartCoroutine(GenEnemigos(intervalo, enemigo));
    }
}
