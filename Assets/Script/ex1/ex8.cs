using System.Threading;
using UnityEngine;

//Crie um script que em que uma
//vari�vel inteira hora seja incrementada de uma unidade a cada 10
//segundos e volte a ser 0 quando alcan�ar o valor 24. Quando
//completar um ciclo, incremente uma vari�vel dias e escreva o
//n�mero de dias que se passaram no console. (Coloque o c�digo
//dentro da fun��o-evento Update).

public class ex8 : MonoBehaviour

{


[SerializeField] int horas = 23;
    [SerializeField] int dias = 1;
    public float minutos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        minutos += Time.deltaTime;

        if (minutos >= 5) { 
            minutos = 0;
            horas++;
 
        } else if (horas == 24)
        {
            horas = 0;
            dias++;
            print("Dia: " +dias);

        }



    }
}
