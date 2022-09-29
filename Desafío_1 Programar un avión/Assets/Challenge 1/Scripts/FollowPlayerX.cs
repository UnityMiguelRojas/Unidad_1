using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    //Declaración de variables
    public GameObject plane;
    //Ubicar la pocisión de la camara para que siga al avión
    private Vector3 offset = new Vector3(20,3,0);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Movimiento de la camara.
        transform.position = plane.transform.position + offset;
    }
}
