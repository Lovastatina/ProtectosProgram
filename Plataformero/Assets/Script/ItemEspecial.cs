using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemEspecial : MonoBehaviour
{
    private Animator miEspecial;
    private EffetiSonore misSonidos;
    public GameObject brillo;

    private void OnTriggerEnter2D(Collider2D col)
    {
        GameObject otroObjeto = col.gameObject;
        Personaggio elPersonn = otroObjeto.GetComponent<Personaggio>();

        if (otroObjeto.tag == "Player" && elPersonn.estaVivo())
        {
                miEspecial.SetTrigger("Recoger");
                misSonidos.reproducir("Especial");
                elPersonn.especial++;
                GetComponent<CapsuleCollider2D>().enabled = false;
                GameObject efectos = Instantiate(brillo);
                efectos.transform.position = transform.position;
                Destroy(gameObject, 0.60f);
        }

    }

    void Start()
    {
        miEspecial = GetComponent<Animator>();
        misSonidos = GetComponent<EffetiSonore>();

    }


    void Update()
    {

    }
}
