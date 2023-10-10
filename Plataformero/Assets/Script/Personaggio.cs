using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaggio : MonoBehaviour
{
    public int hp = 60;
    public int hpMax = 100;
    public int vite = 3;
    public int score = 0;
    public GameObject sangue;
    public GameObject persoVite;
    private Animator miAnimadore;
    private EffetiSonore misSonidos;

    // Start is called before the first frame update
    void Start()
    {
        miAnimadore = GetComponent<Animator>();
        misSonidos = GetComponent<EffetiSonore>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void fareDamage(int puntesDam, GameObject enemigue)
    {
        hp = hp - puntesDam;
        Personaggio elPer = GetComponent<Personaggio>();

       

         if (hp <= 0)
        {
            misSonidos.reproducir("Morte");
            miAnimadore.SetTrigger("morir");
            vite = vite - 1;
            GameObject efettoVite = Instantiate(persoVite);
            efettoVite.transform.position = elPer.transform.position;
        }

        else 
        {
            misSonidos.reproducir("Dannio");

            print(name + "recibe daño de :" + puntesDam + " por " + enemigue);

            miAnimadore.SetTrigger("danniar");
            GameObject efettoSangue = Instantiate(sangue);

            efettoSangue.transform.position = elPer.transform.position;
        }
    }

    public void muerteInstantanea(GameObject who)
    {

        print(name + " murió instantaneamente por" + who);
        hp = 0;
        miAnimadore.SetTrigger("morir");
        Personaggio elPerr = GetComponent<Personaggio>();
        vite = vite - 1;
        GameObject efettoVite = Instantiate(persoVite);
        efettoVite.transform.position = elPerr.transform.position;
    }

}
