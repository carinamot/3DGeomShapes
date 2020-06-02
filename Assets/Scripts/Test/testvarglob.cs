using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testvarglob : MonoBehaviour
{
    public static int globalV;

     void Start()
    {
        globalV = 0;
    }

    private void Update()
    {
        Debug.Log(globalV);
        globalV++;
    }
}
