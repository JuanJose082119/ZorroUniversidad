using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverLibre : MonoBehaviour
{
    // Start is called before the first frame update
     public float speed = 5f;

    // Rango de dirección aleatoria
    public float range = 10f;

    private Vector3 targetPosition;

    void Start () {
        // Inicializa la posición objetivo del objeto en una dirección aleatoria
        targetPosition = GetRandomPosition();
    }

    void Update () {
        // Si el objeto está cerca del destino actual, selecciona un nuevo destino aleatorio
        if (Vector3.Distance(transform.position, targetPosition) < 1f) {
            targetPosition = GetRandomPosition();
        }

        // Mueve el objeto hacia la posición objetivo
        Vector3 direction = (targetPosition - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;
    }

    Vector3 GetRandomPosition () {
        // Genera una posición aleatoria dentro del rango establecido
        Vector3 randomDirection = Random.insideUnitSphere * range;
        randomDirection += transform.position;
        UnityEngine.AI.NavMeshHit hit;
        UnityEngine.AI.NavMesh.SamplePosition(randomDirection, out hit, range, 1);
        return hit.position;
    }
}
