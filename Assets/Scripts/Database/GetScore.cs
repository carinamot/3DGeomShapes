using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GetScore : MonoBehaviour
{
    public TextMeshProUGUI username;
    public Button loginButton;

    void Start()
    {
        username.text = LoginPhp.usernameCopy;
        loginButton.onClick.AddListener(() =>
        {
            StartCoroutine(Mainn.Instance.Web.GetQuiz(username.text));

        });
    }
}
