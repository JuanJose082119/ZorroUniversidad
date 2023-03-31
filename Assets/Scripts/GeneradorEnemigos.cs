using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorEnemigos : MonoBehaviour
{
    [SerializeField] private GameObject[] enemigoPrefab;
    [SerializeField] private float enemigoIntervalo;
    public int random;

    private void Start()
    {        
        StartCoroutine(GenEnemigos(enemigoIntervalo));
    }

    private IEnumerator GenEnemigos(float intervalo)
    {
        random = Random.Range (0,3);
        yield return new WaitForSeconds(intervalo);
        GameObject nuevoEnemigo = Instantiate(enemigoPrefab[random], this.gameObject.transform.position, Quaternion.identity);
        StartCoroutine(GenEnemigos(intervalo));
    }
}
