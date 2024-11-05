using System.Threading;
using UnityEngine;

//Crie um script que em que uma
//variável inteira hora seja incrementada de uma unidade a cada 10
//segundos e volte a ser 0 quando alcançar o valor 24. Quando
//completar um ciclo, incremente uma variável dias e escreva o
//número de dias que se passaram no console. (Coloque o código
//dentro da função-evento Update).

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
