using UnityEngine;

//Crie um script que l� o placar de uma partida entre
//time A e time B. Depois, escreva no console qual dos tr�s
//resultados poss�veis aconteceu: vit�ria do time A, vit�ria do time B
//ou empate. Se o empate teve mais de 3 pontos para cada lado,
//escreva que foi �um empate emocionante�.

public class ex9 : MonoBehaviour
{


    [SerializeField] int timeA;
    [SerializeField] int timeB;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (timeA > timeB)
        {
            print("Vit�ria do time A");
        }
        else if (timeB > timeA)
        {
            print("Vit�ria do time B");
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
