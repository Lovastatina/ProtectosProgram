using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlatoreGUI : MonoBehaviour
{
    public Personaggio Heroe;
    public Text EtiquetaHPHeroe;
    public Image BarraHPHeroe;
    

    // Aishitemaru L
    void Update()
    {
        EtiquetaHPHeroe.text =
            Heroe.hp + "/" + Heroe.hpMax;

        float percentHPHeroe = Heroe.hp / (float)Heroe.hpMax;

        BarraHPHeroe.fillAmount = percentHPHeroe;
    }


}
