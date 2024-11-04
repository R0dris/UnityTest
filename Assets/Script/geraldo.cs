using System;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    //Operadores Relacionais
    //== Igual
    //!= Diferente
    //>  Maior que
    //<  Menor que
    //>= Maior Igual
    //<= Menor Igual

    [SerializeField] int vidaHeroi = 100;
    [SerializeField] int vidaVila = 300;
    string resultado;

    // Start is called once before the first execution of Update after the MonoBehaviour is created  
    void Start()
    {
        //print(vidaVila == vidaHeroi);//false
        //print(vidaVila <= vidaHeroi);//true
        //print(vidaHeroi != vidaVila);//true
        ////Operador Ternário
        ////condição ? valor a ser determinado caso verdadeiro : caso falso
        //resultado = vidaHeroi < vidaVila ? "Vida Herói Menor" : "Vida Herói Maior" ;
        //print (resultado);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
