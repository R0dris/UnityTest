using UnityEngine;


//Ap�s completar uma miss�o, o jogador
//recebe pontos. Verifique se ele ganhou mais de 50 pontos. Se sim,
//exiba "Miss�o bem-sucedida"; caso contr�rio, "Miss�o
//incompleta".


public class ex5 : MonoBehaviour
{

    [SerializeField] bool missaoConcluida;
    [SerializeField] int pontua��o;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //if (missaoConcluida == true)
        //{
        //    pontua��o = pontua��o + 50;
        //}

        if (pontua��o > 50)
        {
            print("Miss�o bem-Sucedida");
        } else if (pontua��o <= 50)
        {
            print("Miss�o Incompleta");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
