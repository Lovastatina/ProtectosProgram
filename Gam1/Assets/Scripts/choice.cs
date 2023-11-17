using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choice : MonoBehaviour
{
    public int fase = 1;
  
    private void aumentar()
    {
        fase++;
    }
    void Update()
    {
        // A = Halagar     B = Regalo

        if (fase == 1)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                print("Dialogo A - <¿Uh? ¿En serio piensas que soy bonita? - Correcto");
                Invoke("aumentar", 0.5f);
            }

            else if (Input.GetKeyDown(KeyCode.B))
            {
                print("Dialogo B - <Alejate de mí> - Incorrecto");
            }

        }
        if (fase == 2)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                print("Dialogo A - <De seguro le dices eso a cualquiera> - Incorrecto");

            }

            else if (Input.GetKeyDown(KeyCode.B))
            {
                print("Dialogo B - ¿Un regalo? ¡¿Para mí?! ¡Eres un amor! - Correcto");
                Invoke("aumentar", 0.5f);
            }

        }
    }
}
