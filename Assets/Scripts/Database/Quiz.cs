using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{
    public TextMeshProUGUI username;
    public Button loginButton;

    void Start()
    {
        username.text = LoginPhp.usernameCopy;
        loginButton.onClick.AddListener(() =>
        {
            StartCoroutine(Mainn.Instance.Web.QuizChecked(username.text));

        });
    }
}
