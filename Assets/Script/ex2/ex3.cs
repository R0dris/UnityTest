using UnityEngine;


//O jogador coleta 3 moedas a
//cada fase. Após 10 fases, exiba o total de moedas coletadas.

public class ex3 : MonoBehaviour
{

    int fase = 1;
    int moedas = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    
        while (fase <= 10)
        {
            moedas = moedas + 3;
            fase++;
        }

        print("Você tem "+ moedas + " moedas");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

