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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void fareDamage(int puntesDam, GameObject enemigue)
    {
        hp = hp - puntesDam;
        print(name + "recibe daño de :" + puntesDam + " por " + enemigue);

        GameObject efettoSangue = Instantiate(sangue);
        Personaggio elPer= GetComponent<Personaggio>();
        efettoSangue.transform.position = elPer.transform.position;
       
        if(hp<=0)
        {
            vite = vite - 1;
            GameObject efettoVite = Instantiate(persoVite);
            efettoVite.transform.position = elPer.transform.position;
        }

    }

    public void muerteInstantanea(GameObject who)
    {
        print(name + " murió instantaneamente por" + who);
        hp = 0;
        Personaggio elPerr = GetComponent<Personaggio>();
        vite = vite - 1;
        GameObject efettoVite = Instantiate(persoVite);
        efettoVite.transform.position = elPerr.transform.position;
    }

}
