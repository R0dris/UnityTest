using UnityEngine;

//1. (Verifica��o de pontos de vida) Um personagem perde pontos
//de vida ap�s uma batalha. Verifique se ele ainda est� vivo. Caso
//tenha mais de 0 pontos de vida, exiba "Personagem Vivo", caso
//contr�rio, "Game Over"



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
