
using UnityEngine;
using UnityEngine.UI;

public class LoginProfeor : MonoBehaviour
{
    public InputField username;
    public InputField password;
    public Button loginButton;

    void Start()
    {
        loginButton.onClick.AddListener(() =>
        {

            StartCoroutine(Mainn.Instance.Web.LoginProf(username.text, password.text));
           // StartCoroutine(Mainn.Instance.Web.LoginProf(username.text, password.text));

        });
    }
}

    
