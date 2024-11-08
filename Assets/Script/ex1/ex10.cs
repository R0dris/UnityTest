using System.Runtime.ConstrainedExecution;
using UnityEditor;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;


//Crie um script onde o jogador pode coletar
//diferentes tipos de itens (como moedas, poções, ou power-ups)
//que têm efeitos diferentes dependendo do tipo coletado. Use um
//switch case para determinar o efeito de cada tipo de item.

public class ex10 : MonoBehaviour
{

    [SerializeField] int itens;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switch (itens)
        {
            case 1:
                print("Luvas de Fúria - Aumentam a força dos golpes, permitindo nocautes rápidos.");
                break;
            case 2:
                print("Kit de Primeiros Socorros - Cura uma parte da vida do jogador ao ser usado.");
                break;
            case 3:
                print("Nunchaku do Relâmpago - Arma de ataques rápidos que causa dano elétrico.");
            break;
            case 4:
            print("Poção de Velocidade - Aumenta temporariamente a velocidade para combos rápidos.");
            break;
            case 5:
            print("Escudo Energético - Barreira temporária que absorve dano dos ataques.");
            break;

            default:
            print("Você só tem 5 itens");
            // code to execute when expression does not match any case
            break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
