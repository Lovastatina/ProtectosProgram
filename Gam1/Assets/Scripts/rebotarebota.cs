using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rebotarebota : MonoBehaviour
{
    private Rigidbody2D Micuerpomisreglas;
    public float Saltof = 5;
    // Start is called before the first frame update
    void Start()
    {
        Micuerpomisreglas = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            print("Se presion� salto");
            Micuerpomisreglas.AddForce(
                new Vector3(0, Saltof, 0),
                ForceMode2D.Impulse);

               
        }
    }
}
