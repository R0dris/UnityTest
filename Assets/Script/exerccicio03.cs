using UnityEngine;




public class exerccicio03 : MonoBehaviour
{

    [SerializeField] bool powerUp;

    [SerializeField] int lifePlayer = 100 ;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (powerUp == true && lifePlayer == 0) {
            lifePlayer = lifePlayer + 50;
            print("Ainda não, vida atual: " +  lifePlayer);
        }else if (lifePlayer == 0 ){
            print("Game Over");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
