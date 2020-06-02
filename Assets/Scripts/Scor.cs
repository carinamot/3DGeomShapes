using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scor : MonoBehaviour
{

    public Transform jucator;
    public Text scor;
    void Update()
    {
        scor.text = jucator.position.z.ToString("0");
    }
}
