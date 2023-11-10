using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanioProgresivo : MonoBehaviour
{
    private Animator miItem;
    private EffetiSonore misSonidos;
    public Personaggio elPersonn;
    public int valorDanio;
    // Start is called before the first frame update

   

    void Start()
    {
        miItem = GetComponent<Animator>();
        misSonidos = GetComponent<EffetiSonore>();
        elPersonn = GetComponent<Personaggio>();
    }

    private void daniarTiempo()
    {
        elPersonn.fareDamage(valorDanio, this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        GameObject otroObjeto = col.gameObject;

        if (otroObjeto.tag == "Player")
        {
            print("Se recogió tesoro");

            Personaggio elPepe = otroObjeto.GetComponent<Personaggio>();

            if (elPepe.estaVivo())
            {
                miItem.SetTrigger("Agarrar");
                misSonidos.reproducir("Veneno");
                InvokeRepeating("daniarTiempo", 0f, 2f);
                GetComponent<CapsuleCollider2D>().enabled = false;
                Destroy(gameObject, 8.1f);

            }

        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
