using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ConoPickup : MonoBehaviour

{
    public static int conosRecolectados = 0;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("¡Encontraste el cono escondido! ¡GANASTE!");
            Destroy(gameObject);
        }
    }
}
