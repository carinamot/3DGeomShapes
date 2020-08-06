using UnityEngine;
using UnityEngine.UI;

public class StudDataB : MonoBehaviour
{
    public Button buttonn;
    void Start()
    {
        buttonn.onClick.AddListener(() =>
        {

            StartCoroutine(Mainn.Instance.Web.GetUsers7B());
        });
    }
}
