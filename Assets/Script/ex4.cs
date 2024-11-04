using UnityEngine;

//Um jogador possui itens limitados
//no inventário. Verifique se o jogador possui uma "Poção de Vida".
//Se possuir, exiba "Usando Poção de Vida"; caso contrário, "Poção
//indisponível".

public class ex4 : MonoBehaviour
{

    [SerializeField] bool Poção;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (Poção == true)
        {
            print("Usando Poção de Vida");
        }
        else {
            print("Poção indisponível");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
