using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Comida : MonoBehaviour
{
    public float hambre = 100f;
    public Image barra;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(hambre);
        if(hambre <= 0){
            //TxtGameO.gameObject.SetActive(true);
            Debug.Log("Perdiste");
        } else if(hambre > 0){
            hambre -= 10f * Time.deltaTime;
        }

        barra.fillAmount = hambre / 100f;
    }
}
