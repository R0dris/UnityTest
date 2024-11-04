using UnityEngine;
using UnityEngine.TextCore.Text;

//Para fazer um jogo de RPG, vamos precisar
//calcular probabilidades e simular a rolagem de dados. Crie um
//script em que o usuário defina o número de faces de um dado
//(int) e calcule a rolagem de um dado com esse número de faces.
//Use a função abaixo para o cálculo: Random.Range(valor_min,
//valor_max); (Coloque o código dentro da função-evento Start).

public class ex7 : MonoBehaviour
{

    [SerializeField] int dado;
    int result;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        result = Random.Range(01, dado);
        print(result);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
