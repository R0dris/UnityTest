using UnityEngine;


//A cada fase completada, a
//dificuldade aumenta em 5 pontos. Exiba a dificuldade após cada
//fase, em um total de 6 fases.

public class ex05 : MonoBehaviour
{

    [SerializeField] int fase = 0;
    [SerializeField] int diff = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


        while (fase < 6)
        {
            print("Dificuldade: " + diff);
            diff = diff + 5;
            fase++;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
