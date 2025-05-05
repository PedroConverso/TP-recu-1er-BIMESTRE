using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalabraSecreta : MonoBehaviour
{
    public string palabraIngresada;

    void Start()
    {
        if (palabraIngresada.ToLower() == "domingo")
            Debug.Log("Palabra correcta");
        else
            Debug.Log("Palabra incorrecta");
    }
}

