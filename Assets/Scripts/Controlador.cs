using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{
    public Joystick miJoystick;
    public int velocidad;
    public Rigidbody miRigidbody;
    public bool conFisicas;
    public GameObject dropeo;
    public bool atacar = false;
    
    void Update(){      

        movimiento.x = miJoystick.Horizontal;
        movimiento.z = miJoystick.Vertical;
        if(Input.GetButtonDown("Fire2"))
        {
            Dash();
        }
    }

    public float dashVelocidad;
    public float dashDuracion;
    public float dashContador;
    private Transform transformJugador;

    Vector3 movimiento = new Vector3();
    public float dashing;

    private void Awake()
    {
        transformJugador= GetComponent<Transform>();
    }

    private void FixedUpdate()
    {
        LoopDash();
    }

    public void Dash()
    {
        dashContador = dashDuracion;
        dashing = 8;
        Invoke("ResetearDash", 0.3f);
    }

    public void ResetearDash()
    {
        dashing = 0;
    }

    public void LoopDash()
    {

        if (dashContador > 0)
        {
            dashContador = dashContador - Time.fixedDeltaTime;
            //miRigidbody.velocity = new Vector3(miRigidbody.velocity.x, miRigidbody.velocity.y, dashVelocidad * transformJugador.localScale.z);
                //new Vector3(dashVelocidad * transformJugador.localScale.x, miRigidbody.velocity.y, dashVelocidad * transformJugador.localScale.z);
        }
        Mover();
    }

    public void Mover()
    {
        Vector3 direccion = Vector3.forward * miJoystick.Vertical + Vector3.right * miJoystick.Horizontal;

        if (conFisicas)
        {
            miRigidbody.AddForce(direccion * velocidad * Time.fixedDeltaTime, ForceMode.Impulse);
        }
        else
        {
            miRigidbody.velocity = (velocidad + dashing) * movimiento;
            //gameObject.transform.Translate(direccion * velocidad * Time.deltaTime);
        }
    }

    private void OnCollisionStay(Collision col){
        if (col.gameObject.tag == "Enemigo"){
            Debug.Log("choca");
            if (atacar){
                Destroy(col.gameObject);
                Instantiate(dropeo, col.gameObject.transform.position, Quaternion.identity);
                atacar = false;
            }
        }
    }

    public void Atacar(){
        atacar = true;
    }

    
}
