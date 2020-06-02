using UnityEngine;
using UnityEngine.UI;

public class StudData : MonoBehaviour
{
    public Button buttonn;
    void Start()
    {
        buttonn.onClick.AddListener(() =>
        {

            StartCoroutine(Mainn.Instance.Web.GetUsers());
        });
    }
}
