using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_1 : MonoBehaviour
{
    string nombre = "Juan";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("¡Hola Mundo!");
        Debug.Log("Este es el primer videojuego de " + nombre);
        Debug.Log("Estoy aprendiendo C#");

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Ha pasado un frame"); // aparece tantas veces porque en el update se hace cada frame
    }
}
