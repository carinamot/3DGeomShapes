using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

    public static Main Instanta;
    public Users user;
    // Start is called before the first frame update
    void Start()
    {
        Instanta = this;
        user = GetComponent<Users>();
    }
}
   
