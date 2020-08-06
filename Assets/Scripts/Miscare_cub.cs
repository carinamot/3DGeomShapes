using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Miscare_cub : MonoBehaviour
{

    //MISCA CUBUL CU SAGETI
    
    float speed= 35;
     void Update()
     {
        
        transform.Rotate(0, Input.GetAxis("Horizontal") * speed * Time.deltaTime, Input.GetAxis("Vertical") * speed * Time.deltaTime);
    }


}
