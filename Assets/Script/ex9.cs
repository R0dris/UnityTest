using UnityEngine;

//Crie um script que lê o placar de uma partida entre
//time A e time B. Depois, escreva no console qual dos três
//resultados possíveis aconteceu: vitória do time A, vitória do time B
//ou empate. Se o empate teve mais de 3 pontos para cada lado,
//escreva que foi “um empate emocionante”.

public class ex9 : MonoBehaviour
{


    [SerializeField] int timeA;
    [SerializeField] int timeB;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (timeA > timeB)
        {
            print("Vitória do time A");
        }
        else if (timeB > timeA)
        {
            print("Vitória do time B");
        }
        else if (timeA == timeB && timeA <=3 && timeB<= 3) {

            print("Empate");


        } else if (timeB > 3 && timeA > 3 && timeA == timeB) {

            print("Um empate emocionante");
        
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
