using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sinCeros : MonoBehaviour
{
    // Start is called before the first frame update
    public class SinCeros : MonoBehaviour
    {
        public float numero1;
        public float numero2;

        void Start()
        {
            if (numero2 != 0)
                Debug.Log("El resultado es " + (numero1 / numero2));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
