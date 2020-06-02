using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using TMPro;
using UnityEngine.UI;

public class Users : MonoBehaviour
{
    public Text t;
    public GameObject username;
    public GameObject parola;
    private string Username;
    private string Parola;

    void Start()
    {
        t.text = "";
        //StartCoroutine(GetUsers());
        //StartCoroutine(Login("elena","ele"));
        // StartCoroutine(Register("elena", "ele", "ele"));
      
    }
   

    public IEnumerator GetUsers()
    {
        using (UnityWebRequest www = UnityWebRequest.Get("http://localhost:1123/Unity/Users.php"))
        {
            yield return www.Send();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);

                byte[] results = www.downloadHandler.data;
            }
        }
    }
    public IEnumerator Login(string username, string parola)
        {
            WWWForm form = new WWWForm();
            form.AddField("loginUser", username);
            form.AddField("loginPass", parola);

            using (UnityWebRequest www = UnityWebRequest.Post("http://localhost:1123/Unity/Login.php", form))
            {
                yield return www.Send();
                t.text = www.downloadHandler.text;

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
    

    public IEnumerator Register(string username, string parola, string confPass)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUser", username);
        form.AddField("loginPass", parola);
        form.AddField("logiConfPass", confPass);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost:1123/Unity/Register.php", form))
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


    void Update()
    {
        //La apasarea TAB

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (username.GetComponent<InputField>().isFocused)
            {
                parola.GetComponent<InputField>().Select();
            }
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (Username != "" && Parola != "")
            {
                Login("","");
            }

        }


       
    }

}
