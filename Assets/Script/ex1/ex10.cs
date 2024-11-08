using System.Runtime.ConstrainedExecution;
using UnityEditor;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;


//Crie um script onde o jogador pode coletar
//diferentes tipos de itens (como moedas, po��es, ou power-ups)
//que t�m efeitos diferentes dependendo do tipo coletado. Use um
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
                print("Luvas de F�ria - Aumentam a for�a dos golpes, permitindo nocautes r�pidos.");
                break;
            case 2:
                print("Kit de Primeiros Socorros - Cura uma parte da vida do jogador ao ser usado.");
                break;
            case 3:
                print("Nunchaku do Rel�mpago - Arma de ataques r�pidos que causa dano el�trico.");
            break;
            case 4:
            print("Po��o de Velocidade - Aumenta temporariamente a velocidade para combos r�pidos.");
            break;
            case 5:
            print("Escudo Energ�tico - Barreira tempor�ria que absorve dano dos ataques.");
            break;

            default:
            print("Voc� s� tem 5 itens");
            // code to execute when expression does not match any case
            break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
