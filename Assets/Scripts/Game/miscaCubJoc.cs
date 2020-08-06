using UnityEngine;

public class miscaCubJoc : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardFotce=2000f;
    public float sideForce = 500f;

    void FixedUpdate()//unity prefera FU atunci cand lucram cu phisics 
    {
        rb.AddForce(0, 0, forwardFotce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y<-5f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }

   
}
