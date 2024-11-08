using UnityEngine;

//O jogador pode escolher entre o
//personagem Guerreiro ou Mago. Exiba "Guerreiro escolhido" se o
//jogador selecionar Guerreiro e "Mago escolhido" se selecionar
//Mago.

public class ex6 : MonoBehaviour
{
    [SerializeField] bool guerreiro;
    [SerializeField] bool mago;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (guerreiro == true && mago == false)
        {
                
            print("Guerreiro Escolhido");
        }
        else if (guerreiro == false && mago == true)
        {
            print("Mago Escolhido");
        }
        else if (guerreiro == true && mago == true)
        {
            {
                print("Escolha apenas um");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
