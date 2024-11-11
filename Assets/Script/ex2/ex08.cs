using System;
using UnityEngine;


//Escreva um programa que inverte uma
//string usando um loop for.

public class ex08 : MonoBehaviour
{
     [SerializeField]   string texto;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        string textoInvertido = "";

        for (int i = texto.Length - 1; i >= 0; i--)
        {
            textoInvertido += texto[i];
        }

        // Exibe a string invertida
        print("String original: " + texto);
        print("String invertida: " + textoInvertido);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
