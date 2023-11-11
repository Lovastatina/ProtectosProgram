using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemVel : MonoBehaviour
{
    private Animator miItem;
    private EffetiSonore misSonidos;
   
   
    private void normalizar()
    {
        Control caver = GameObject.FindGameObjectWithTag("Player").GetComponent<Control>();
        caver.velCaminar = caver.velCaminar / 2;
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        GameObject otroObjeto = col.gameObject;

        if (otroObjeto.tag == "Player")
        {
            print("Se recogió bebida");

            Control caver = GameObject.FindGameObjectWithTag("Player").GetComponent<Control>();
            caver.velCaminar = caver.velCaminar * 2;
            Invoke("normalizar", 2.9f);
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<CapsuleCollider2D>().enabled = false;
            Destroy(gameObject, 3f);


        }

    }

    // Start is called before the first frame update
    void Start()
    {
        miItem = GetComponent<Animator>();
        misSonidos = GetComponent<EffetiSonore>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
