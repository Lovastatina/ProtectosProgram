using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanioProgresivo : MonoBehaviour
{
    private Animator miItem;
    private EffetiSonore misSonidos;
    public int valorDanio = 10;
    public GameObject veneno;
    // Start is called before the first frame update



    void Start()
    {
        miItem = GetComponent<Animator>();
        misSonidos = GetComponent<EffetiSonore>();
       
    }

    private void daniarTiempo()
    {
        Personaggio elPersonn = GameObject.FindGameObjectWithTag("Player").GetComponent<Personaggio>();
        elPersonn.fareDamage(valorDanio, this.gameObject);
        misSonidos.reproducir("Veneno");
        GameObject efettoVeneno = Instantiate(veneno);
        efettoVeneno.transform.position = elPersonn.transform.position;
       
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        GameObject otroObjeto = col.gameObject;

        if (otroObjeto.tag == "Player")
        {
            print("Se envenenó");

            Personaggio elPepe = otroObjeto.GetComponent<Personaggio>();

            if (elPepe.estaVivo())
            {
                
                miItem.SetTrigger("Agarrar");
                InvokeRepeating("daniarTiempo", 0.5f, 3f);
                GetComponent<CapsuleCollider2D>().enabled = false;
                Destroy(gameObject, 9f);
              

            }

        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
