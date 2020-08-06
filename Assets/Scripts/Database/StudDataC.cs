using UnityEngine;
using UnityEngine.UI;

public class StudDataC : MonoBehaviour
{

    public Button buttonn;
    void Start()
    {
        buttonn.onClick.AddListener(() =>
        {

            StartCoroutine(Mainn.Instance.Web.GetUsers7C());
        });
    }
}
