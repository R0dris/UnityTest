using UnityEngine;



//Para cada número entre 0 e 10000, escreva apenas
//“fizz” no console quando for divisível por 3, “buzz” quando for
//divisível por 5 e “fizz buzz” quando for divisível pelos dois. Se o
//número não for divisível por nenhum deles, escreva-o no console.


public class ex06 : MonoBehaviour
{

    float numero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        numero = Random.Range(0, 10000);
        if (numero % 3 == 0)
        {
            print(numero);
            print("Buzz");
        }
        else if (numero % 5 == 0)
        {
            print(numero);
            print("Fizz");
        }
        else if (numero % 5 == 0 && numero % 3 == 0)
        {
            print(numero);
            print("BuzzFizz");
        }
        else {
            print(numero);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
