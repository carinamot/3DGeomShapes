using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpdatePasStud : MonoBehaviour
{
    public TMP_InputField username;
    public TMP_InputField password;
    public Button updatePasButton;

    void Start()
    {
        updatePasButton.onClick.AddListener(() =>
        {

            StartCoroutine(Mainn.Instance.Web.UpdatePasStud(username.text, password.text));
           // Debug.Log(password);
        });

    }
}
