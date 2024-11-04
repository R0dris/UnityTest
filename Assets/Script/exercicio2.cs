using System;
using UnityEngine;

//2. (Detecção de power - up) Ao coletar um power-up, o
//personagem aumenta sua velocidade. Se o jogador encontrar um
//power-up, exiba "Power-up Coletado". Caso contrário, exiba
//"Nenhum power-up encontrado".

public class exercicio2 : MonoBehaviour
{

    [SerializeField] bool powerUp;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (powerUp == true)
        {
            print("Power Up Coletado");
        }
        else
        {
            print("Nenhum power-up encontrado");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
