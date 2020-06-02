using UnityEngine;

public class Coliziune : MonoBehaviour
{
    public miscaCubJoc miscare;
   

     void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacol")
        {
            miscare.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
          
        }
    }

}
