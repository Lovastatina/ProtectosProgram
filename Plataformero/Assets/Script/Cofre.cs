using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cofre : MonoBehaviour
{
    private Animator miItem;
    private EffetiSonore misSonidos;
    public GameObject anuncio;
    private bool contacto;
    public GameObject PrefabMoneda;
    public Transform cofre;
   
    // Start is called before the first frame update
    void Start()
    {
        miItem = GetComponent<Animator>();
        misSonidos = GetComponent<EffetiSonore>();
        
   }

    private void aparecer()
    {
        Instantiate(PrefabMoneda, cofre.position,cofre.rotation);
        
     
        
    }
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        GameObject otroObjeto = col.gameObject;

        if (otroObjeto.tag == "Player")
        {
            print("Se recogi� tesoro");

            Personaggio elPersonn = otroObjeto.GetComponent<Personaggio>();

            if (elPersonn.estaVivo())
            {
                anuncio.SetActive(true);
                contacto = true;
                
            }

        }

    }

    private void OnTriggerExit2D(Collider2D col)
    {
        anuncio.SetActive(false);
        contacto = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (contacto)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                miItem.SetTrigger("abrir");
                GetComponent<CapsuleCollider2D>().enabled = false;
                Invoke("aparecer", 0.5f);
                Destroy(gameObject, 2.5f);
            }
        }
    }
}
