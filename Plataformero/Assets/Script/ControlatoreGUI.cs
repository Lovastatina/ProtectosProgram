using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlatoreGUI : MonoBehaviour
{
    public Personaggio Heroe;
    public Text EtiquetaHPHeroe;
    public Image BarraHPHeroe;
    public Text ViteHeroe;
    public Text ScoreHeroe;

    public Personaggio Villano;
    public Text EtiquetaHPVillano;
    public Image BarraHPVillano;

    public Text TesoroHeroe;

    public GameObject gameOver;

   // private void OnEnable()
   // {
   //     Personaggio.muerteFinal += activarMenu;
   // }

   // private void OnDisable()
   // {
   //     Personaggio.muerteFinal -= activarMenu;
   // }

   // public void activarMenu()
   // {
   //     gameOver.SetActive(true);
   // }

    void Update()
    {
        EtiquetaHPHeroe.text = Heroe.hp + "/" + Heroe.hpMax;

        float percentHPHeroe = Heroe.hp / (float)Heroe.hpMax;

        BarraHPHeroe.fillAmount = percentHPHeroe;

        ViteHeroe.text = Personaggio.vite +"";

        ScoreHeroe.text = "Score: " + Heroe.score + "";


        EtiquetaHPVillano.text = Villano.hp + "/" + Villano.hpMax;

        float percentHPVillano = Villano.hp / (float)Villano.hpMax;

        BarraHPVillano.fillAmount = percentHPVillano;


        TesoroHeroe.text = Heroe.dinero + "";



        if (Personaggio.vite == 0)
        {
            gameOver.SetActive(true);
        }

        else
        {
            gameOver.SetActive(false);
        }

    }


}
