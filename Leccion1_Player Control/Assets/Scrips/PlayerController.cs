using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidad=30;

    public float velGiro=20;

    private float avanza;
    
    private float gira;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Valores en que el usuario ingresa atravez de las flechas de arriba y hacia abajo.
         gira = Input.GetAxis("Horizontal");
        // Valores que el usuario ingresa con la flechas de izquiera a derecha.
        avanza = Input.GetAxis("Vertical");

        //Operación para Avanzar hacia delante
        transform.Translate(Vector3.forward*Time.deltaTime*velocidad*avanza);
        //Opreación para Girar a los lados
        transform.Rotate(Vector3.up, Time.deltaTime*velGiro*gira);
    }
}
