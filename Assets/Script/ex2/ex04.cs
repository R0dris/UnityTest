using UnityEngine;

//Cada combo realizado aumenta em 10
//pontos. Exiba a pontua��o total ap�s 7 combos.

public class ex04 : MonoBehaviour
{

    [SerializeField] int combo = 0;
    [SerializeField] int ponto = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


        while (combo < 7)
        {
            print("Voc� tem " + ponto + " pontos");
            ponto = ponto + 10;
            combo++;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
