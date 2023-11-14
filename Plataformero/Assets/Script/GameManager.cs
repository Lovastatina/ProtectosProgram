using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static float respawnX;
    public static float respawnY;
   
    // Start is called before the first frame update
    void Start()
    {
        if (respawnX != 0)
        {
            GameObject caver = GameObject.FindGameObjectWithTag("Player");
            caver.transform.position = new Vector2(respawnX, respawnY);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
