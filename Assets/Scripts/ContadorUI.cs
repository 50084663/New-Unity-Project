using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorUI : MonoBehaviour
{
    public Text textoContador;

    void Update()
    {
        textoContador.text = "Conos: " + ConoPickup.conosRecolectados;
    }
}
