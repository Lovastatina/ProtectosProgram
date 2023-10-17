using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        GameObject otroObjeto = col.gameObject;

        if (otroObjeto.tag == "Enemigo")
        {
            print(name + " Detecté colisión con " + otroObjeto);
            Personaggio elEne = otroObjeto.GetComponent<Personaggio>();

            elEne.fareDamage(20, this.gameObject);

        }

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
