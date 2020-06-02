using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScore : MonoBehaviour
{
    public TextMeshProUGUI usernameS;
    public TextMeshProUGUI score;
    public Button updateButton;
    public string user;
    public int quizScore;

    void Start()
    {
        usernameS.text = LoginPhp.usernameCopy;
        score.text = UIManager.CurrentScoreCopy.ToString();
        updateButton.onClick.AddListener(() =>
        {

            StartCoroutine(Mainn.Instance.Web.UpdateScore(usernameS.text, score.text));
            Debug.Log(score);
        });

    }

}

