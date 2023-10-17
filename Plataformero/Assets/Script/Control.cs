using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour

{
    public float velCaminar = 10;
    public float fuerzaSalto = 23;
    public bool enPiso;
    int e = 2 ;

    private Rigidbody2D miCuerpo;
    private Animator miAnimador;
    private EffetiSonore misSonidos;
    // Start is called before the first frame update
    void Start()
    {
        miCuerpo = GetComponent<Rigidbody2D>();
        miAnimador = GetComponent<Animator>();
        misSonidos = GetComponent<EffetiSonore>();
    }

    // Update is called once per frame
    void Update()
    {
        detectarPiso();

        float velVert = miCuerpo.velocity.y;

        float movHoriz = Input.GetAxis("Horizontal");

        bool movSalto = Input.GetButtonDown("Jump");

        if (Input.GetButtonDown("Fire1"))
        {
            miAnimador.SetTrigger("golpear");
        }
        
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

        if (enPiso == true & movSalto == true)
        {
            misSonidos.reproducir("Salto");
            e = 2;
            miCuerpo.AddForce(transform.up * fuerzaSalto, ForceMode2D.Impulse);
            e = e - 1;
        }

        else if (e > 0 & movSalto==true)
        {
            misSonidos.reproducir("Salto");
            miCuerpo.AddForce(transform.up * fuerzaSalto, ForceMode2D.Impulse);
            e = e- 1;
        }
         

    
        

        miAnimador.SetFloat("vel_ver", velVert);

    }

    void detectarPiso()
    {
        enPiso = Physics2D.Raycast(
            transform.position,  //desde donde sale el rasho
            Vector2.down, //en que dirección
            0.1f
            );

    }

  
}
