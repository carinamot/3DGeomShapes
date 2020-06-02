using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Miscare_cub : MonoBehaviour
{

    //MISCA CUBUL CU SAGETI
    /* void Update()
     {
         transform.Translate(Input.GetAxis("Horizontal")*Time.deltaTime,0f,Input.GetAxis("Vertical")*Time.deltaTime);
     }*/

    /* //nu merge
    public float torque;
    public Rigidbody rb;

    private void Start()
    {
        float forward = Input.GetAxis("Vertical");
        float turn = Input.GetAxis("Horizontal");
        rb.AddTorque(transform.right * torque * turn);
        rb.AddTorque(transform.forward*torque*forward);
    }*/
    float speed= 35;
     void Update()
     {
        //transform.Rotate(new Vector3(0f, 1f, 0f));
        // transform.Rotate(Vector3.one * 20 * Time.deltaTime);
        transform.Rotate(0, Input.GetAxis("Horizontal") * speed * Time.deltaTime, Input.GetAxis("Vertical") * speed * Time.deltaTime);
    }


}
