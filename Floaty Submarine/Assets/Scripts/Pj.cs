using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pj : MonoBehaviour
{
    public int salto = 10;
    private Rigidbody2D rg;
    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rg.velocity = Vector2.up * salto;
        }

        if (this.transform.position.y <= -3 || this.transform.position.y >=4)
        {
            Mostrarpuntaje.puntaje = 0;
            SceneManager.LoadScene("Flappyplay");
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Puntos"))
        {
        }
        else
        {
            SceneManager.LoadScene("Flappyplay");
            Mostrarpuntaje.puntaje = 0;
            
        }
    }
}
