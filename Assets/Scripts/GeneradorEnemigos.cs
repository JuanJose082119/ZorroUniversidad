using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorEnemigos : MonoBehaviour
{
    [SerializeField] private GameObject[] enemigoPrefab;
    [SerializeField] private float enemigoIntervalo;
    public Comida com;
    public bool boss = true;
    private int contBoss = 3;

    private void Start()
    {        
        StartCoroutine(GenEnemigos(enemigoIntervalo));
    }

    private IEnumerator GenEnemigos(float intervalo)
    {
        int random = Random.Range (0,3);
        yield return new WaitForSeconds(intervalo);
        GameObject nuevoEnemigo = Instantiate(enemigoPrefab[random], this.gameObject.transform.position, Quaternion.identity);
        StartCoroutine(GenEnemigos(intervalo));
    }

    void Update(){
        if(com.contKill == 10 && boss){
            Boss();
        }
    }

    private void Boss(){
        if(contBoss < 7){
            GameObject Boss = Instantiate(enemigoPrefab[contBoss], this.gameObject.transform.position, Quaternion.identity);
            boss = false;
            contBoss++;
        }
        
    }
}
