using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{
    public Joystick miJoystick;
    public int velocidad;
    public Rigidbody miRigidbody;
    public bool conFisicas;
    public bool atacar;

    void Update(){
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity)){
            Debug.Log("choca");
            EnemigoObjetos mod = hit.collider.gameObject.GetComponent<EnemigoObjetos>();
            if (mod != null && atacar){
                mod.vida -= 10f;
                atacar = false;
            }
        }
    }

    private void FixedUpdate()
    {
        Vector3 direccion = Vector3.forward * miJoystick.Vertical + Vector3.right * miJoystick.Horizontal;

        if(conFisicas)
        {
            miRigidbody.AddForce(direccion * velocidad * Time.fixedDeltaTime, ForceMode.Impulse);
        }
        else
        {
            gameObject.transform.Translate(direccion * velocidad * Time.deltaTime);
        }
    }    

    public void Atacar(){
        atacar = true;
    }

    public void Dash()
    {
        Debug.Log("Estoy corriendo");
    }
}
