using System;
using UnityEngine;


//Escreva um programa que inverte uma
//string usando um loop for.

public class ex08 : MonoBehaviour
{
        // Exemplo de string a ser invertida
     [SerializeField]   string texto;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // Variável para armazenar a string invertida
        string textoInvertido = "";

        // Percorre a string do último caractere até o primeiro
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
