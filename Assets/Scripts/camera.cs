using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject cub;
    private Vector3 of;
    void Start()
    {
        of = transform.position - cub.transform.position;   
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = cub.transform.position + of;
    }
}
 