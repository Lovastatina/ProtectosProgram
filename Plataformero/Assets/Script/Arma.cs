using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D colli)
    { 

        GameObject otroObjetto = colli.gameObject;



        
        if (otroObjetto.tag == "Enemigo")
        {
            print(name + " Detect� colisi�n con " + otroObjetto);

            Personaggio elEnemigo = otroObjetto.GetComponent<Personaggio>();

            elEnemigo.fareDamage(20, this.gameObject);



        }
        

    }

}
