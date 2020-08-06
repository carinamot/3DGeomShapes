using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DeleteProf : MonoBehaviour
{
    public TMP_InputField username;
    public Button buttonn;
    void Start()
    {
        buttonn.onClick.AddListener(() =>
        {

            StartCoroutine(Mainn.Instance.Web.DeleteProf(username.text));
        });
    }
}
