using System.Collections.Generic;
using System;
using UnityEngine;


//Dada uma lista de números,
//encontre o maior valor.

public class ex07 : MonoBehaviour
{
        List<int> numeros = new List<int> { 10,27, 7, 14, 32, 5 };
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        int maior = numeros[0];
            
        foreach (int numero in numeros)
        {
            if (numero > maior)
            {
                maior = numero;
            }
        }

        print("O maior valor é: " + maior);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
