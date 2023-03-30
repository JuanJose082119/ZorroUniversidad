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
        GameObject nuevoEnemigo = Instantiate(enemigo, new Vector3(Random.Range(-5f, 5), 1 , Random.Range(-6f, 6)), Quaternion.identity);
        StartCoroutine(GenEnemigos(intervalo, enemigo));
    }
}
