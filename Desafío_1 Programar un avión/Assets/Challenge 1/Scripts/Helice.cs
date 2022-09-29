using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Este script se creo para manipular la helice del avión
public class Helice : MonoBehaviour
{
    //Declaración de variable
    public float velocidad = 1000.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Hacer que se mueva la helice hacia adelante multiplicado por la velicidad para que sea rapido.
        transform.Rotate(Vector3.forward*velocidad);
    }
}
