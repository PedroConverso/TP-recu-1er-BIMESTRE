using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositivoHastaNueve : MonoBehaviour
{
    public int numero;

    void Start()
    {
        if (numero > 0 && numero < 10)
            Debug.Log("El número es positivo y menor a 10.");
        else
            Debug.Log("El número no cumple con las condiciones.");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
