using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text.RegularExpressions;
using UnityEngine.UI;

public class InregistrareProf : MonoBehaviour
{
    public GameObject Pusername;
    public GameObject Pemail;
    public GameObject Ppassword;
    public GameObject PconfirmPassword;
    public Text tt;
    private string Username;
    private string Password;
    private string Email;
    private string ConfirmPassword;
    private string form;// in el se regasesc: Username, Password, Email, Conf
    private bool EmailValid = false;
    public int ok;
    private string[] characters = { "a","b","c","d","e","f","g","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z",
        "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z",
        "1","2","3","4","5","6","7","8","9","0","-","_","."};


    public void ButonInregistrare()
    {
        bool UN = false;
        bool EM = false;
        bool PW = false;
        bool CPW = false;
        if (Username != "")
        {
            if (!System.IO.File.Exists(@"C:/LICENTA Practic/Incercare/DATABASEUNITYPROF/" + Username + ".txt"))
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

        if (Email != "")
        {
            EmailValidation();
            if (EmailValid)
            {
                if (Email.Contains("@") && Email.Contains("."))
                {
                    EM = true;
                }
                else
                {
                    tt.text = "Email invalid!";
                }
            }
            else
            {
                tt.text = "Email invalid!";
            }
        }
        else
        {
            tt.text = "Adaugați email!";
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

        if (UN == true && EM == true && PW == true && CPW == true)
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
            form = (Username + "\n" + Email + "\n" + Password);
            System.IO.File.WriteAllText(@"C:/LICENTA Practic/Incercare/DATABASEUNITYPROF/" + Username + ".txt", form);

            Pusername.GetComponent<InputField>().text = "";
            Pemail.GetComponent<InputField>().text = "";
            Ppassword.GetComponent<InputField>().text = "";
            PconfirmPassword.GetComponent<InputField>().text = "";
            print("Înregistrare reușită!");

        }

    }

    void EmailValidation()
    {
        bool Start = false;
        bool End = false;
        for (int i = 0; i < characters.Length; i++)
        {
            if (Email.StartsWith(characters[i]))
            {
                Start = true;
            }
        }
        for (int i = 0; i < characters.Length; i++)
        {
            if (Email.EndsWith(characters[i]))
            {
                End = true;
            }
        }
        if (Start == true && End == true)
        {
            EmailValid = true;
        }
        else
        {
            EmailValid = false;
        }
    }


    void Update()
    {

        //La apasarea TAB
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (Pusername.GetComponent<InputField>().isFocused)
            {
                Pemail.GetComponent<InputField>().Select();
            }
            if (Pemail.GetComponent<InputField>().isFocused)
            {
                Ppassword.GetComponent<InputField>().Select();
            }
            if (Ppassword.GetComponent<InputField>().isFocused)
            {
                PconfirmPassword.GetComponent<InputField>().Select();
            }
        }
        //ENTER
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (Username != "" && Email != "" && Password != "" && ConfirmPassword != "")
            {
                ButonInregistrare();
            }

        }

        Username = Pusername.GetComponent<InputField>().text;
        Email = Pemail.GetComponent<InputField>().text;
        Password = Ppassword.GetComponent<InputField>().text;
        ConfirmPassword = PconfirmPassword.GetComponent<InputField>().text;

    }
}
