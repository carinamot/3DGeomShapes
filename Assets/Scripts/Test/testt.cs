using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class testt : MonoBehaviour
{
     public string user;

    private void Update()
    {
        user = LoginPhp.usernameCopy;
        Debug.Log(user);

    }
}
