using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DineroSuficiente : MonoBehaviour
{
    public float montoDinero;
    public float precio1;
    public float precio2;

    void Start()
    {
        float total = precio1 + precio2;

        if (montoDinero == total)
            Debug.Log("El monto de dinero es exactamente suficiente");
        else if (montoDinero < total)
            Debug.Log("El monto de dinero es insuficiente");
        else
            Debug.Log("El monto de dinero es mas que los dos precios.");
    }

    
    void Update()
    {
     
    }
}
