using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHell : MonoBehaviour
{
    public Transform juegador;

    void start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(juegador.position.x, juegador.position.y, -1);
        
    }
}
