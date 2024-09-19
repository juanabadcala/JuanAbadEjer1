using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_4 : MonoBehaviour
{
    int vidas = 10;
    int inclementoVidas;
    int decrementarVidas;
    int cuadruplicarVidas;

    // Start is called before the first frame update
    void Start()
    {
        inclementoVidas = vidas + 77;
        Debug.Log(inclementoVidas);

        decrementarVidas = vidas - 3;
        Debug.Log(decrementarVidas);

        cuadruplicarVidas = vidas * 4;
        Debug.Log(cuadruplicarVidas);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
