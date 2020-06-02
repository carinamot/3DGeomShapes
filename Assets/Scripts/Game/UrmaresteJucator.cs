using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UrmaresteJucator : MonoBehaviour
{
    public Transform jucator;//Transform pt a urmari coordonatele jucatorului
    public Vector3 offset;
    void Update()
    {
        transform.position = jucator.position+offset;
    }
}
