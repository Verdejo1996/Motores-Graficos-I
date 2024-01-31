using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoAzul : MonoBehaviour
{
    public GameObject enemigo;
    private float timer = 0;
    public Collider colision;
    // Start is called before the first frame update
    void Start()
    {

    }



    // Update is called once per frame

    void Update()
    {
        Debug.Log(timer);

        if ((int)timer == 3)
        {
            Vector2 vec = Vector2.zero;
            vec.y = Random.Range(6, 8);
            vec.x = Random.Range(-3, 4);
            Instantiate(enemigo, vec, Quaternion.identity);
            timer = 0;

        }
        else
        {
            timer += Time.deltaTime;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(enemigo);
    }
}
