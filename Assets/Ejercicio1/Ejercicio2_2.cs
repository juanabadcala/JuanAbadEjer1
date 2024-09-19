using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_2 : MonoBehaviour
{
    int vidas = 10;
    float experiencia = 18.4f;
    char carac = 'A';
    float resultadoSuma;
    float resultadoResta;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(vidas);
        Debug.Log(experiencia);

        resultadoSuma = vidas  + experiencia;
        Debug.Log(resultadoSuma);

        resultadoResta = experiencia - vidas;
        Debug.Log(resultadoResta);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
