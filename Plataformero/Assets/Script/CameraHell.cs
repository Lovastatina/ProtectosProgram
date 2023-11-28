using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHell : MonoBehaviour
{
    public Personaggio Heroe;
  

    void start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Heroe.estaVivo())
        {
            transform.position = new Vector3(Heroe.transform.position.x, Heroe.transform.position.y +3.5f, -1);
        }
        
    }
}
