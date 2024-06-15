using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float velocidad;
    public float da�o;

    void Update()
    {
        transform.Translate(Vector2.right * velocidad *  Time.deltaTime);
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Jugador2"))
        {
            //other.GetComponent<Jugador2>().TomarDa�o();
            Destroy(gameObject);
        }
    }
}
