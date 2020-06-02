using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text.RegularExpressions;
using UnityEngine.UI;

public class Inregistrare : MonoBehaviour
{
    public GameObject username;
    public GameObject password;
    public GameObject confirmPassword;
    public Text tt;
    private string Username;
    private string Password;
    private string ConfirmPassword;
    private string form;// in el se regasesc: Username, Password, Conf
    public int ok;
    private string[] characters = { "a","b","c","d","e","f","g","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z",
        "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z",
        "1","2","3","4","5","6","7","8","9","0","-","_","."};


    public void ButonInregistrare()
    {
        bool UN = false;
        bool PW = false;
        bool CPW = false;
        if (Username != "")
        {
            if (!System.IO.File.Exists(@"C:/LICENTA Practic/Incercare/DATABASEUNITY/" + Username + ".txt"))
            {
                UN = true;
            }
            else
            {
                tt.text = "Username existent!";
            }
        }
        else
        {
            tt.text = "Adaugă username!";
        }
        

        if (Password != "")
        {
            if (Password.Length > 5)
            {
                PW = true;
            }
            else
            {
                tt.text = "Parola trebuie să conțină minim 5 caractere!";
            }
        }
        else
        {
            tt.text = "Introduceți parola!";
        }
        if (ConfirmPassword != "")
        {
            if (ConfirmPassword == Password)
            {
                CPW = true;
            }
            else
            {
                tt.text = "Parolele trebuie să coincidă!";
            }
        }
        else
        {
            tt.text = "Introduceți parola!";
        }

        if (UN == true && PW == true && CPW == true)
        {
            bool oki = true;
            int i = 1;
            foreach (char c in Password)
            {
                if (oki)
                {
                    Password = "";
                    oki = false;
                }
                i++;
                char encrypted = (char)(c * i);
                Password += encrypted.ToString();
            }
            form = (Username + "\n" + Password);
            System.IO.File.WriteAllText(@"C:/LICENTA Practic/Incercare/DATABASEUNITY/" + Username + ".txt", form);

            username.GetComponent<InputField>().text = "";
            password.GetComponent<InputField>().text = "";
            confirmPassword.GetComponent<InputField>().text = "";
            print("Înregistrare reușită!");

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
            if (password.GetComponent<InputField>().isFocused)
            {
                confirmPassword.GetComponent<InputField>().Select();
            }
        }
        //ENTER
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (Username != "" && Password != "" && ConfirmPassword != "")
            {
                ButonInregistrare();
            }

        }

        Username = username.GetComponent<InputField>().text;
        Password = password.GetComponent<InputField>().text;
        ConfirmPassword = confirmPassword.GetComponent<InputField>().text;

    }
}
