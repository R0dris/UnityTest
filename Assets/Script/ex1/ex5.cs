using UnityEngine;


//Após completar uma missão, o jogador
//recebe pontos. Verifique se ele ganhou mais de 50 pontos. Se sim,
//exiba "Missão bem-sucedida"; caso contrário, "Missão
//incompleta".


public class ex5 : MonoBehaviour
{

    [SerializeField] bool missaoConcluida;
    [SerializeField] int pontuação;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //if (missaoConcluida == true)
        //{
        //    pontuação = pontuação + 50;
        //}

        if (pontuação > 50)
        {
            print("Missão bem-Sucedida");
        } else if (pontuação <= 50)
        {
            print("Missão Incompleta");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
