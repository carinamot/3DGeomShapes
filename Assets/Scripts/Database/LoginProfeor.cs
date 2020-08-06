
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoginProfeor : MonoBehaviour
{
    public TMP_InputField usernameP;
    public TMP_InputField passwordP;
    public Button loginButton;

    void Start()
    {
        loginButton.onClick.AddListener(() =>
        {

            StartCoroutine(Mainn.Instance.Web.LoginProf(usernameP.text, passwordP.text));
          

        });
    }
}

    
