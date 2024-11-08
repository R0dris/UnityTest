using UnityEditorInternal;
using UnityEngine;



//Um personagem ataca cinco vezes, e o
//dano do ataque aumenta em 2 a cada vez. Exiba o dano a cada
//ataque.


public class ex2 : MonoBehaviour
{

    [SerializeField] int ataque = 0;
    [SerializeField] float dmg = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    
        while (ataque < 5)
        {   
            print("Dano de: " + dmg);
            dmg = dmg + 2;
            ataque++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
