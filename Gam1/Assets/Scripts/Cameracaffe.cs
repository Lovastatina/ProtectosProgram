using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameracaffe : MonoBehaviour
{
    //atributo
    public Transform Pelotaz;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once pelusa por aqui pelusa por alla
    void Update()
    {
        transform.position = new Vector3(
            Pelotaz.position.x, //Pos x
            Pelotaz.position.y, //Pos y
            -1);                //Pos z

    }
}
