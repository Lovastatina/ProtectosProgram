using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaggio : MonoBehaviour
{
    public int hp = 60;
    public int hpMax = 100;
    public int vite = 3;
    public int score = 0;

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
    }

    public void muerteInstantanea(GameObject who)
    {
        print(name + " murió instantaneamente por" + who);
        hp = 0;
    }

}
