using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaMorta : MonoBehaviour
{
    public GameObject splashAguaPrefab;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otroObjeto =collision.gameObject;

        if (otroObjeto.tag == "Player")
        {
            print(name + " Detecté colisión con " + otroObjeto);

            Personaggio elPerson = otroObjeto.GetComponent<Personaggio>();

            elPerson.muerteInstantanea(this.gameObject);

            GameObject efettoSplash = Instantiate(splashAguaPrefab);
            efettoSplash.transform.position = elPerson.transform.position;

        }
    }
    
}
