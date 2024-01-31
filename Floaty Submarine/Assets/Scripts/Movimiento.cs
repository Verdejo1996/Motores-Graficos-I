using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vec = transform.position;
        vec.x -= velocidad* Time.deltaTime;
        transform.position = vec;
        if(gameObject != null)
        {
            if (transform.position.x<= -40)
            {
                Destroy(gameObject);
            }
        }

      //  AumentarVelocidad(velocidad);
    }

    // float AumentarVelocidad(float velocidad)
    //{
    //    if (Mostrarpuntaje.puntaje == 3)
    //    {
    //        velocidad = velocidad*5;
    //    }
    //    return velocidad;
    //}
}
