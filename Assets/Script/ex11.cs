using UnityEngine;


//Implemente um sistema de diálogos onde o jogador
//pode interagir com um NPC (personagem não jogável), e o NPC
//responde com diferentes frases dependendo do estado do jogo.
//Use switch case para definir as respostas baseadas no estado do
//jogador.

public class ex11 : MonoBehaviour
{

    [SerializeField] bool npc;
    int npcFrase;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        npcFrase = Random.Range(01, 05);
        if (npc == true)
        {
            switch (npcFrase)
            {
                case 1:
                    print("Você chegou tarde... o perigo já tomou conta daqui!");
                    break;
                case 2:
                    print("Lembre-se: nem todos que ajudam são seus amigos de verdade.");
                    break;
                case 3:
                    print("Dizem que um tesouro está escondido na colina, mas ninguém voltou para contar.");
                    break;
                case 4:
                    print("Cuidado com as sombras, é lá que o verdadeiro inimigo se esconde.");
                    break;
                case 5:
                    print("Se quer sobreviver, aprenda a escutar o silêncio.");
                    break;
                default:
                    // code to execute when expression does not match any case
                    break;
            }
        }
        else
        {
            print("Interja com o NPC para ouvir seu destino");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
