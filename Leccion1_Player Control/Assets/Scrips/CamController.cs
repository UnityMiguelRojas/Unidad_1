using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject tanque;

    //Ubicación de la cámara
    public Vector3 upCam = new Vector3(0,10,-10);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Movimiento de la camara para seguir al objeto, es decir al tanque.
        transform.position=tanque.transform.position+upCam;
    }
}
