using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_3 : MonoBehaviour
{
    int vidas = 10;
    float exp = 12.4f;
    float resultadoProducto;
    float resultadoCociente;
    float resultadoResto;
    float DobleVidas;
    float tripleexp;

    // Start is called before the first frame update
    void Start()
    {
        resultadoProducto = vidas * exp;
        Debug.Log(resultadoProducto);

        resultadoCociente = vidas / exp;
        Debug.Log(resultadoCociente);

        resultadoResto = vidas % exp;
        Debug.Log(resultadoResto);

        DobleVidas = 2 * vidas;
        Debug.Log(DobleVidas);

        tripleexp = 3 * exp;
        Debug.Log(tripleexp);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
