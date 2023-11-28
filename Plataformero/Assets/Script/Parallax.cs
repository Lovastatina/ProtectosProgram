using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float anchoFondo = 20;
    public float anchoCam = 16;

    public float perAlcance = 1;
   
    public float disActual;
    private Transform camara;
    public float diferenciax;
    private float posXInicial;
    void Start()
    {
        camara = Camera.main.transform;
        posXInicial = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        float xCamActual = camara.position.x;
        float xCapaActual = transform.position.x;


         

        float distanciaReal = xCamActual - xCapaActual;
        float distanciaMaxima = anchoCam / 2 + anchoFondo / 2;
        Vector3 posNueva;
        if(distanciaReal > distanciaMaxima)
        {
            float xNueva = xCamActual + distanciaMaxima;
             posNueva = new Vector3(xNueva, transform.position.y, transform.position.z);
            posXInicial = xNueva;
        }

        else
        {
            diferenciax = xCamActual - posXInicial;
            posNueva = new Vector3(xCamActual - diferenciax * perAlcance, transform.position.y, transform.position.z);
            
        }
        transform.position = posNueva;



    }
}
