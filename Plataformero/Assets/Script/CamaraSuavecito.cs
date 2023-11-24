using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraSuavecito : MonoBehaviour
{
    public Personaggio Obiettivo;
    public float offsetProfundidad = -5f;
    public float offsetVertical = -1f;
    public float velDes = 2f;
    // Start is called before the first frame update


    // Update is called once per frame
    void LateUpdate()
    {


        Vector3 posDestino = new Vector3(Obiettivo.transform.position.x, Obiettivo.transform.position.y + offsetVertical, Obiettivo.transform.position.z + offsetProfundidad);

        if (Obiettivo.estaVivo())
        {
            transform.position = Vector3.Lerp(transform.position, posDestino, Time.deltaTime * velDes);
        }
    }
}