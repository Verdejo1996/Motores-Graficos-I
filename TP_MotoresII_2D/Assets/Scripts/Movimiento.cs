using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    private Rigidbody2D rigidbody2;
    public float velocidad;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputMovimiento = Input.GetAxis("Horizontal");
        Rigidbody2D rigidbody2 = GetComponent<Rigidbody2D>();

        rigidbody2.velocity = new Vector2(inputMovimiento * velocidad, rigidbody2.velocity.y);
    }
}
