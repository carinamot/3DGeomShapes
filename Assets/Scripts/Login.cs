using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    public GameObject username;
    public GameObject password;
    private string Username;
    private string Password;
    private String[] Liniii;
    private string decrypted;
    public Text ttext;
    private int scenaCurenta;

    public void ButonLogin()
    {
        bool UN = false;
        bool PW = false;

        if (Username != "")
        {
            if (System.IO.File.Exists(@"C:/LICENTA Practic/Incercare/DATABASEUNITY/" + Username + ".txt"))
            {
                UN = true;
                Liniii = System.IO.File.ReadAllLines(@"C:/LICENTA Practic/Incercare/DATABASEUNITY/" + Username + ".txt");
            }
            else
            {
                ttext.text="Username incorect!";
            }
        }
        else
        {
            ttext.text = " Introduceti username!";
        }

        if (Password != "")
        {
            if (System.IO.File.Exists(@"C:/LICENTA Practic/Incercare/DATABASEUNITY/" + Username + ".txt"))
            {

                int i = 1;
                foreach (char d in Liniii[1])
                {
                    i++;
                    char decrypt = (char)(d / i);
                    decrypted += decrypt.ToString();
                }
                if (Password == decrypted)
                {
                    PW = true;
                }
                else
                {
                    ttext.text = "Parola incorectă!";
                }
            }
            else
            {
                ttext.text = " Invalid!";
            }

        }
        else
        {
            ttext.text = "Introduceți parola!";

        }

        if(UN==true && PW == true)
        {
            if(Username=="admin" && Password=="Admin1234")
            {
                print("Logarea a fost făcută cu succes!");
                scenaCurenta = SceneManager.GetActiveScene().buildIndex;
                PlayerPrefs.SetInt("Scena salvata", scenaCurenta);
                SceneManager.LoadScene(0);
            }
            else
            {
                print("Logarea a fost făcută cu succes!");
                /* scenaCurenta = SceneManager.GetActiveScene().buildIndex;
                 PlayerPrefs.SetInt("Scena salvata", scenaCurenta);
                 SceneManager.LoadScene(5);
                 */
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            username.GetComponent<InputField>().text = "";
            password.GetComponent<InputField>().text = "";
           

        }
    }


    void Update()
    {
        //La apasarea TAB

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (username.GetComponent<InputField>().isFocused)
            {
                password.GetComponent<InputField>().Select();
            }
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (Username != "" && Password != "")
            {
                ButonLogin();
            }

        }


        Username = username.GetComponent<InputField>().text;
        Password = password.GetComponent<InputField>().text;
    }
}

