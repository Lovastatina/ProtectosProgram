using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private Animator miItem;
    private EffetiSonore misSonidos;
    public GameObject fire;
    

    private void OnTriggerEnter2D(Collider2D col)
    {
        GameObject otroObjeto = col.gameObject;
        Personaggio elPersonn = otroObjeto.GetComponent<Personaggio>();


        if (otroObjeto.tag == "Player" && elPersonn.estaVivo())
        {
            GameManager.respawnX= transform.position.x;
            GameManager.respawnY = transform.position.y;
            GetComponent<BoxCollider2D>().enabled = false;
            GameObject efectos = Instantiate(fire);
            efectos.transform.position = transform.position;
            misSonidos.reproducir("check");
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
