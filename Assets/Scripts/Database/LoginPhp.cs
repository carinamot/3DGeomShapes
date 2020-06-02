using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoginPhp : MonoBehaviour
{
    public TMP_InputField username;
    public static string usernameCopy;
    public TMP_InputField password;
    public Button loginButton;

    void Start()
    {
        loginButton.onClick.AddListener(() =>
        {
            usernameCopy = username.text;
             StartCoroutine(Mainn.Instance.Web.Login(username.text, password.text));
           
        });
    }

    
}
