using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class Web : MonoBehaviour
{
    public TextMeshProUGUI answer;
  

    void Start()
    {
       // StartCoroutine(GetUsers());
       // StartCoroutine(Login("carina", "cari"));
       // StartCoroutine(Register("eu","123","123"));
    }

   public IEnumerator GetUsers()
    {
        using(UnityWebRequest www = UnityWebRequest.Get("http://localhost:1123/Licenta/unity.php"))
        {
            yield return www.Send();

            if(www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            { //show results as text
                answer.text = www.downloadHandler.text;
                //retrive results as binary
                //byte[] results = www.downloadHandler.data;
            }
        }
    }

    public IEnumerator Login(string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("userr", username);
        form.AddField("passsword", password);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost:1123/Licenta/login.php",form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            { //show results as text
                answer.text = www.downloadHandler.text;//get the text from php file

                if (www.downloadHandler.text.Contains("Credentiale incorecte!") || www.downloadHandler.text.Contains("Username inexsistent!"))
                {
                    Debug.Log(" Mai incearca!");
                }

                else
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
            }
        }

    }

    public IEnumerator LoginProf(string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("userr", username);
        form.AddField("passsword", password);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost:1123/Licenta/loginProf.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            { //show results as text
                Debug.Log(www.downloadHandler.text);//get the text from php file

                if (www.downloadHandler.text.Contains("Credentiale incorecte!") || www.downloadHandler.text.Contains("Username inexsistent!"))
                {
                    Debug.Log(" Mai incearca!");
                }

                else
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
            }
        }

    }

    public IEnumerator Register(string username, string password, string grade, string email)
    {
        WWWForm form = new WWWForm();
        form.AddField("userr", username);
        form.AddField("passsword", password);
        form.AddField("grade", grade);
        form.AddField("email", email);


        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost:1123/Licenta/register.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            { //show results as text
              //Debug.Log(www.downloadHandler.text);//get the text from php file
                answer.text = www.downloadHandler.text;
            }
        }
    }



    public IEnumerator UpdateScore(string username, string score)
    {
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("score", score);


        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost:1123/Licenta/update.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            { //show results as text
              Debug.Log(www.downloadHandler.text);//get the text from php file
              //  answer.text = www.downloadHandler.text;
            }
        }
    }
}
