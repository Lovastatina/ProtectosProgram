using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampa : MonoBehaviour
{
  
    private void OnCollisionEnter2D(Collision2D collision)
    { //Este m�todo se ejecuta cuando detecta una colisi�n 

        GameObject otroObjeto = collision.gameObject;

        if(otroObjeto.tag == "Player")
        {
            print(name + " Detect� colisi�n con " + otroObjeto);

            Personaggio elPerso = otroObjeto.GetComponent<Personaggio>();

            elPerso.fareDamage(20, this.gameObject);



        }
    }

        
}
