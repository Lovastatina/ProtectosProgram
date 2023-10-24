using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Personaggio : MonoBehaviour
{
    public int hp = 60;
    public int hpMax = 100;
    public static int vite = 2;
    public int score = 0;
    public GameObject sangue;
    public GameObject persoVite;
    private Animator miAnimadore;
    private EffetiSonore misSonidos;
    public bool block = false;



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

    public bool estaVivo()
    {
        return hp > 0;
    }
    private void desbloquear()
    {
        block = false; 
    }

    private void reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       
    }
    public void fareDamage(int puntesDam, GameObject enemigue)
    {
        hp = hp - puntesDam;
        block = true;
        Invoke("desbloquear",1.2f);
        Personaggio elPer = GetComponent<Personaggio>();

       

         if (hp <= 0)
        {
         
            misSonidos.reproducir("Morte");
            miAnimadore.SetTrigger("morir");
            
            GameObject efettoVite = Instantiate(persoVite);
            efettoVite.transform.position = elPer.transform.position;
            Personaggio.vite = Personaggio.vite - 1;

            if (tag == "Player" && Personaggio.vite!=0)
            {
                
                Invoke("reiniciar", 3f);
               
            }
        }

        else if (estaVivo())
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
        block = true;
        print(name + " murió instantaneamente por" + who);
        hp = 0;
        misSonidos.reproducir("Morte");
        miAnimadore.SetTrigger("morir");
        Personaggio elPerr = GetComponent<Personaggio>();
        Personaggio.vite = Personaggio.vite - 1;
        GameObject efettoVite = Instantiate(persoVite);
        efettoVite.transform.position = elPerr.transform.position;

        if (tag == "Player" && Personaggio.vite != 0)
        {

            Invoke("reiniciar", 3f);

        }
    }

}
