using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Meta : MonoBehaviour
{
    private Animator miItem;
    private EffetiSonore misSonidos;
    public GameObject goal;
    public GameObject curar;

    void Start()
    {
        miItem = GetComponent<Animator>();
        misSonidos = GetComponent<EffetiSonore>();
    }

    private void cambiarNivel()
    {
        SceneManager.LoadScene("EscenaProve", LoadSceneMode.Single );
    }

    private void efectoz()
    {
        GameObject efectos = Instantiate(goal);
        efectos.transform.position = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        GameObject otroObjeto = col.gameObject;
        Personaggio elPersonn = otroObjeto.GetComponent<Personaggio>();


        if (otroObjeto.tag == "Player" && elPersonn.estaVivo())
        {
            GetComponent<CapsuleCollider2D>().enabled = false;

            misSonidos.reproducir("check");
            elPersonn.block = true;
            Animator caver = elPersonn.GetComponent<Animator>();
            caver.SetTrigger("ganar");
            InvokeRepeating("efectoz", 0f, 2f);
            Invoke("cambiarNivel", 4.5f);

            if (elPersonn.especial != 0)
            {
                
                Personaggio.vite += elPersonn.especial;
                GameObject heal = Instantiate(curar);
                heal.transform.position = elPersonn.transform.position;

            }
        }

    }

    
}
