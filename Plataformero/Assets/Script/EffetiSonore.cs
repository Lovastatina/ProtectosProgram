using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[RequireComponent(typeof(AudioSource)) ]
public class EffetiSonore : MonoBehaviour
{
    public Effetto[] misEfectos;
    private AudioSource reproductor;

    private void Start()
    {
        reproductor = GetComponent<AudioSource>();
    }

    public void reproducir(string azzione)
    {
        foreach(Effetto ef in misEfectos)
        {
            if (ef.azione == azzione)
            {
                reproductor.clip = ef.archivoSonido;
                reproductor.Play();

                return;
            }

        }
    }

    [Serializable]
    public class Effetto
    {
        public string azione;
        public AudioClip archivoSonido;
       

    
    }
}
