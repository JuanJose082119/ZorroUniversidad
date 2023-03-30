using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemigo : MonoBehaviour
{  
    [SerializeField] float distancia;
  
    bool _isAgro = false;
    NavMeshAgent _nMAgent;
    float Charspeed;
    Vector3 target;

    
    void Start()
    {
        target = this.transform.position;
        _nMAgent = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player"){
            target = other.transform.position;
            _isAgro = true;
        }
    }

     void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player"){
            _isAgro = false;
        }
    }
    
    void Update()
    {
        DetectHigh(); 
        Distancia();       
        
        if(_isAgro){
            _nMAgent.destination = target;
        }
        
    }


    private void DetectHigh(){
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, Mathf.Infinity)){
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.down) * hit.distance, Color.red);
        }
    }

    private void Distancia(){   
        distancia = Vector3.Distance(target, transform.position);

        if(distancia <= 1){
            Debug.Log("PERDISTE");   
            _isAgro = false;

        }

    }
}
