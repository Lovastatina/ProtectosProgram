using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChisaiiNemico : MonoBehaviour
{
    public float velCam = 10;
    private bool cerca;
    private Rigidbody2D elCuerpo;
    private Animator elAnimador;
    private GameObject heroJugador;
    public float rangoAgro = 3;
    public Transform caver;
    public Transform nemico;
    private Personaggio elEnemigo;
    public GameObject enemico;
    public GameObject PrefabRecompensa;

    private void aparecer()
    {
        GameObject Recompensa = Instantiate(PrefabRecompensa);
        Recompensa.transform.position = new Vector2(transform.position.x,transform.position.y - 0.55f);


    }

    private void OnTriggerEnter2D(Collider2D col) 
    {
        GameObject otroObjeto = col.gameObject;

        if (otroObjeto.tag == "Player")
        {
            print("Se está cerca");
            cerca = true;
        }

    }
     void OnTriggerExit2D(Collider2D coll)
    {
        GameObject otroObjeto = coll.gameObject;
        
        if (otroObjeto.tag == "Player")
        {
            print("Se está lejos");
            cerca = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collisionn)
    { 

        GameObject otroObjeto = collisionn.gameObject;

        if (otroObjeto.tag == "Player")
        {
 

            Personaggio elPersonn = otroObjeto.GetComponent<Personaggio>();

            if (elPersonn.estaVivo())
            {
                elPersonn.fareDamage(20, this.gameObject);
                
            }


        }
    }


    void Start()
    {
        elCuerpo = GetComponent<Rigidbody2D>();
        elAnimador = GetComponent<Animator>();
        elEnemigo = GetComponent<Personaggio>();
        heroJugador = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        Vector3 miPos = this.transform.position;
        Vector3 posHeroe = heroJugador.transform.position;
        float distanciaHeroe = (miPos - posHeroe).magnitude;
        Personaggio heroeVivo = heroJugador.GetComponent<Personaggio>();

        if (distanciaHeroe < rangoAgro && heroeVivo.estaVivo())
        {
            cerca = true;
        }


        else 
        {
            cerca = false;
        }


        if (cerca==true && elEnemigo.estaVivo())
        {
            elAnimador.SetBool("Cam", true);
            if (caver.position.x < nemico.position.x)
            {
                elCuerpo.velocity = new Vector3(-velCam, 0, 0);
                transform.rotation = Quaternion.Euler(0, 0, 0);

            }

            else if (nemico.position.x < caver.position.x)
            {
                elCuerpo.velocity = new Vector3(velCam, 0, 0);
                transform.rotation = Quaternion.Euler(0, 180, 0);
            }

            
        }

       else
        {
            elAnimador.SetBool("Cam", false);

        }

        if (!elEnemigo.estaVivo())
        {
            GetComponent<BoxCollider2D>().enabled = false;
            elCuerpo.simulated = false;
            Invoke("aparecer", 1.3f);
            Destroy(gameObject, 1.3f);
           

        }


        

    }
}
