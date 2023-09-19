using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour

{
    public float velCaminar = 10;
    public float fuerzaSalto = 23;

    private Rigidbody2D miCuerpo;
    private Animator miAnimador;
    // Start is called before the first frame update
    void Start()
    {
        miCuerpo = GetComponent<Rigidbody2D>();
        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float velVert = miCuerpo.velocity.y;

        float movHoriz = Input.GetAxis("Horizontal");

        bool movSalto = Input.GetButtonDown("Jump");

        if(movHoriz > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            miCuerpo.velocity = new Vector3(velCaminar, velVert, 0);
            miAnimador.SetBool("Caminando", true);         
        }

        else if(movHoriz<0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            miCuerpo.velocity = new Vector3(-velCaminar, velVert, 0);
            miAnimador.SetBool("Caminando", true);

        }

        else
        {
            miCuerpo.velocity = new Vector3(0, velVert, 0);
            miAnimador.SetBool("Caminando", false);
        }

        if (movSalto == true) {
            miCuerpo.AddForce(transform.up*fuerzaSalto, ForceMode2D.Impulse);
            
        }

        miAnimador.SetFloat("vel_ver", velVert);
   


    }
  
}
