using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ReglasManager : MonoBehaviour
{
    private float Timer;
    public GameObject ProyectilComun;
    public static int ContadorPuntaje = 0; // el static evita que la instancia de la variable se destruya y permite ser usada en otros ámbitos
    private string TextoPuntaje;


    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        InstanciarProyectil();

        TextoPuntaje = "Puntaje: " + ContadorPuntaje.ToString();
        GameObject.Find("Puntaje").GetComponent<TextMeshProUGUI>().text = TextoPuntaje; //No actualiza el puntaje en pantalla

    }


    void InstanciarProyectil()
    {
        if ((int)Timer == 2)
        {
            Vector2 SpawnProyectil = Vector2.zero;
            SpawnProyectil.x = Random.Range(-6, 6);
            SpawnProyectil.y = Random.Range(6, 8);
            Instantiate(ProyectilComun, SpawnProyectil, Quaternion.identity);
            Timer = 0;
        }
        else
        {
            Timer += Time.deltaTime;
        }
    }
}
