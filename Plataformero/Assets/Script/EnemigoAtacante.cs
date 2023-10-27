using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoAtacante : MonoBehaviour
{
    public float velCam = 3;
    private bool cerca;
    private Rigidbody2D elCuerpo;
    private Animator elAnimador;
    private GameObject heroJugador;
    public float rangoAgro = 5;
    public float rangoAtaque = 3;
    public Transform caver;
    public Transform nemico;
    private Personaggio elEnemigo;




    private void OnTriggerEnter2D(Collider2D collisionn)
    {

        GameObject otroObjeto = collisionn.gameObject;

        if (otroObjeto.tag == "Player")
        {


            Personaggio elPersonn = otroObjeto.GetComponent<Personaggio>();

           
                elPersonn.fareDamage(20, this.gameObject);
           
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


        if (cerca == true && elEnemigo.estaVivo())
        {
            elAnimador.SetBool("Cam", true);
            if (caver.position.x < nemico.position.x)
            {
                elCuerpo.velocity = new Vector3(-velCam, 0, 0);
                transform.rotation = Quaternion.Euler(0, 180, 0);

            }

            else if (nemico.position.x < caver.position.x)
            {
                elCuerpo.velocity = new Vector3(velCam, 0, 0);
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }


        }

        else
        {
            elAnimador.SetBool("Cam", false);

        }

        if (distanciaHeroe < rangoAtaque && heroeVivo.estaVivo() && elEnemigo.estaVivo())
        {
            elAnimador.SetTrigger("atacar");
            elCuerpo.velocity = new Vector3(0, 0, 0);
            elAnimador.SetBool("Cam", false);
            GetComponent<BoxCollider2D>().enabled = true;
            


        }

        else
        {
            GetComponent<BoxCollider2D>().enabled = false;
        }




    }
}
