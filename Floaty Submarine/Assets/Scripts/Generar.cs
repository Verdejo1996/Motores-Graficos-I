using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generar : MonoBehaviour
{
    public GameObject picos;
    //variables para crearlo en cierto periodo de tiempo 
    public int tiempo_generar;
    public float reloj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (reloj > tiempo_generar)
        {
            GameObject Generar = Instantiate(picos);
            Generar.transform.position = transform.position + new Vector3(0, Random.Range(-2.3f, 1.4f), 0);
            reloj = 0;
            AumentarVelocidad();
        }
        else
        {
            reloj += Time.deltaTime;

        }
    }

    void AumentarVelocidad()
    {
        if (Mostrarpuntaje.puntaje == 3)
        {
            tiempo_generar = 5;
        }
        else if(Mostrarpuntaje.puntaje == 5)
        {
            tiempo_generar = 4;
        }
        else if(Mostrarpuntaje.puntaje == 7)
        {
            tiempo_generar = 3;
        }
        else if(Mostrarpuntaje.puntaje == 10)
        {
            tiempo_generar = 2;
        }
    }
}
