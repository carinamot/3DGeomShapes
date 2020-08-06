using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Registerprof : MonoBehaviour
{
    public TMP_InputField usernameProf;
    public TMP_InputField passwordProf;
    public TMP_InputField emailProf;
    public Button registerButton;


    void Start()
    {
        registerButton.onClick.AddListener(() =>
        {

            StartCoroutine(Mainn.Instance.Web.RegisterProf(usernameProf.text, passwordProf.text, emailProf.text));
        });

    }
}
