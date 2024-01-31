using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptJugador : MonoBehaviour
{
    
    [SerializeField] float Velocidad = 10f;
    float horizontal;

    
 
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector2(0,-4.7f);
    }

    // Update is called once per frame
    void Update()
    {
       horizontal = Input.GetAxisRaw("Horizontal");
        
        
    }

    private void FixedUpdate()
    {
       
        Vector2 Movimiento = new Vector2(horizontal * Velocidad * Time.deltaTime, 0);
        this.transform.position = (Vector2)this.transform.position + Movimiento;
        
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
       if (other.gameObject.name == "ProyectilComun(Clone)")
        {
            Destroy(other.gameObject);
            ReglasManager.ContadorPuntaje++; //Aquí se aprovecha el static de ContadorPuntaje. Como es de otro script, la sintaxis debe indicarlo de esta manera.
        }
    }
}
