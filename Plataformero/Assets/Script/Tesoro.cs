using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tesoro : MonoBehaviour
{
    private Animator miTesoro;
    private EffetiSonore misSonidos;
    

    public int valorScore;
    public int valorDinero;
    private void OnTriggerEnter2D(Collider2D col)
    {
        GameObject otroObjeto = col.gameObject;

        if (otroObjeto.tag == "Player")
        {
            print("Se recogió tesoro");

            Personaggio elPersonn = otroObjeto.GetComponent<Personaggio>();

            if (elPersonn.estaVivo())
            {
                miTesoro.SetTrigger("Recoger");
                misSonidos.reproducir("Dinero");
                elPersonn.dinero+= valorDinero;
                elPersonn.score += valorScore;
                GetComponent<CapsuleCollider2D>().enabled = false;
                Destroy(gameObject, 0.60f);
                
            }

        }

    }
    // Start is called before the first frame update
    void Start()
    {
        miTesoro = GetComponent<Animator>();
        misSonidos = GetComponent<EffetiSonore>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
