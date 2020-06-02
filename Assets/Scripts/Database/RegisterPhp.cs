using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RegisterPhp : MonoBehaviour
{
    public TMP_InputField username;
    public TMP_InputField password;
    public TMP_InputField grade;
    public TMP_InputField email;
    public Button registerButton;


    void Start()
    {
        registerButton.onClick.AddListener(() =>
        {

            StartCoroutine(Mainn.Instance.Web.Register(username.text, password.text, grade.text, email.text));
        });

    }

}

