using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DeleteStud : MonoBehaviour
{
    public TMP_InputField username;
    public Button buttonn;
    void Start()
    {
        buttonn.onClick.AddListener(() =>
        {

            StartCoroutine(Mainn.Instance.Web.DeleteStud(username.text));
        });
    }
}
