using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nose : MonoBehaviour
{
    private Vector3 posStart = Vector3.zero;
    private Rigidbody2D miCuerpo;

    public float vel;
    private Vector2 pos;

    public int MaxX = 2;
    public int MaxY = 2;
    public int MinX = -2;
    public int MinY = -2;

    void Start()
    {
        miCuerpo = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            GetComponent<Control>().enabled = true;
            GetComponent<Nose>().enabled = false;
            miCuerpo.isKinematic = false;
        }
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        pos.x += horizontal;
        pos.y += vertical;

        pos.x = Mathf.Clamp(pos.x, MinX, MaxX);
        pos.y = Mathf.Clamp(pos.y, MinY, MaxY);

        transform.position = Vector2.Lerp(transform.position, pos, vel);
        
    }
}
