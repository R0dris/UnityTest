using UnityEngine;

//1. (Verificação de pontos de vida) Um personagem perde pontos
//de vida após uma batalha. Verifique se ele ainda está vivo. Caso
//tenha mais de 0 pontos de vida, exiba "Personagem Vivo", caso
//contrário, "Game Over"



public class exercicio01 : MonoBehaviour
{

    [SerializeField] int playerLife;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (playerLife > 0)
        {
            print("Personagem Vivo");
        }
        else
        {
            print("Game Over");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
