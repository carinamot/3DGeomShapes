using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpdatePasProf : MonoBehaviour
{

    public TMP_InputField username;
    public TMP_InputField password;
    public Button updatePasButton;

    void Start()
    {
        updatePasButton.onClick.AddListener(() =>
        {

            StartCoroutine(Mainn.Instance.Web.UpdatePasProf(username.text, password.text));
            // Debug.Log(password);
        });

    }
}
