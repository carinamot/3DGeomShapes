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

   public IEnumerator GetUsers7A()
    {
        using(UnityWebRequest www = UnityWebRequest.Get("http://localhost:1123/Licenta/7A.php"))
        {
            yield return www.Send();

            if(www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            { 
                answer.text = www.downloadHandler.text;
              
            }
        }
    }

    public IEnumerator GetUsers7B()
    {
        using (UnityWebRequest www = UnityWebRequest.Get("http://localhost:1123/Licenta/7B.php"))
        {
            yield return www.Send();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            { 
                answer.text = www.downloadHandler.text;
            
            }
        }
    }

    public IEnumerator GetUsers7C()
    {
        using (UnityWebRequest www = UnityWebRequest.Get("http://localhost:1123/Licenta/7C.php"))
        {
            yield return www.Send();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                answer.text = www.downloadHandler.text;
               
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
            { 
                answer.text = www.downloadHandler.text;

                if (www.downloadHandler.text.Contains("Credentiale incorecte!") || www.downloadHandler.text.Contains("Username inexsistent!"))
                {
                    Debug.Log(" Mai incearca!");
                }

                else
                {
                    if (www.downloadHandler.text.Contains("Admin!"))
                    {
                        SceneManager.LoadScene("Admin");
                    }
                    else
                    {
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                    }
                   
                }
            }
        }

    }

    public IEnumerator LoginProf(string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("usernameProf", username);
        form.AddField("passswordProf", password);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost:1123/Licenta/loginP.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                answer.text = www.downloadHandler.text;

                if (www.downloadHandler.text.Contains("Credentiale incorecte!") || www.downloadHandler.text.Contains("Username inexsistent!"))
                {
                    Debug.Log(" Mai incearca!");
                }

                else
                {
                    if (www.downloadHandler.text.Contains("Admin!"))
                    {
                        SceneManager.LoadScene("Admin");
                    }
                    else
                    {
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                    }

                }
            }
        }

    }


    public IEnumerator Register(string firstName, string lastName, string username, string password, string grade, string email)
    {
        WWWForm form = new WWWForm();
        form.AddField("firstName", firstName);
        form.AddField("lastName", lastName);
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
            { 
                answer.text = www.downloadHandler.text;
            }
        }
    }

    public IEnumerator RegisterProf(string username, string password, string email)
    {
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("password", password);
        form.AddField("email", email);


        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost:1123/Licenta/registerP.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            { 
              Debug.Log(www.downloadHandler.text);
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
            { 
              Debug.Log(www.downloadHandler.text);
              //  answer.text = www.downloadHandler.text;
            }
        }
    }

    public IEnumerator QuizChecked(string username)
    {
        WWWForm form = new WWWForm();
        form.AddField("username", username);


        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost:1123/Licenta/quiz.php", form))
        {

            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
               // answer.text = www.downloadHandler.text;

                if (www.downloadHandler.text.Contains("Quiz-ul NU a fost efectuat!"))
                {
                    SceneManager.LoadScene("Quizz");
                }

                else
                {
                    SceneManager.LoadScene("GetQuizScore");
                   

                }
            }
        }
    }

    public IEnumerator GetQuiz(string username)
    {
        WWWForm form = new WWWForm();
        form.AddField("username", username);


        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost:1123/Licenta/getQuizScore.php", form))
        {

            yield return www.SendWebRequest();


            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            { 
               // Debug.Log(www.downloadHandler.text);
                answer.text = www.downloadHandler.text;
            }
        }
    }

    public IEnumerator UpdatePasStud(string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("password", password);


        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost:1123/Licenta/UpdatePasStud.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            { 
                Debug.Log(www.downloadHandler.text);
            }
        }
    }

    public IEnumerator UpdatePasProf(string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("password", password);


        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost:1123/Licenta/UpdatePasProf.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            { 
                Debug.Log(www.downloadHandler.text);
            }
        }
    }

    public IEnumerator DeleteStud(string username)
    {
        WWWForm form = new WWWForm();
        form.AddField("username", username);


        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost:1123/Licenta/deleteStud.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            { 
                Debug.Log(www.downloadHandler.text);
            }
        }
    }

    public IEnumerator DeleteProf(string username)
    {
        WWWForm form = new WWWForm();
        form.AddField("username", username);


        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost:1123/Licenta/deleteProf.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            { 
                Debug.Log(www.downloadHandler.text);
            }
        }
    }
}
