using UnityEngine;


//Crie uma contagem
//regressiva de 5 a 1 e exiba "Início da partida!" ao final.



public class ex1 : MonoBehaviour
{
    [SerializeField] int i = 5;
    [SerializeField] float tempo = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        while (tempo > 1)
        {

            tempo--;
            print(tempo);
        }

        if (tempo == 1)
        {
            print("Início da partida!!");
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
        
    
}
