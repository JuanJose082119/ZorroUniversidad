using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{
    public Joystick miJoystick;
    public int velocidad;
    public Rigidbody miRigidbody;
    public bool conFisicas;

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

    public void Ataque()
    {
        Debug.Log("Estoy atacando");
    }

    public void EfectoDash()
    {
        Debug.Log("Estoy corriendo");
    }
}
