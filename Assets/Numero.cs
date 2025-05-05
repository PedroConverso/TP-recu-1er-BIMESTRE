using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Numero : MonoBehaviour
{
    public int numero1;
    public int numero2;

    void Start()
    {
        if (numero1 > numero2)
            Debug.Log("El mayor de los dos números ingresados es " + numero1);
        else if (numero2 > numero1)
            Debug.Log("El mayor de los dos números ingresados es " + numero2);
        else
            Debug.Log("Ambos números son iguales.");
    }
}
