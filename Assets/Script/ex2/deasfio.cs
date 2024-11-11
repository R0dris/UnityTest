using UnityEngine;

public class deasfio : MonoBehaviour
{


    [SerializeField] string palavra;
    string letra;
    int contador;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < palavra.Length; i++)
        {
            letra += palavra[i];
            if (letra != "a" & letra != "e" & letra != "i" & letra != "o" & letra != "u")
            {
                contador++;
                letra = "";
            }
            else
            {
                letra = "";
            }
        }
        print(contador);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
