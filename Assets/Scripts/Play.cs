using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    private int scenaCurenta;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Lessons()
    {
        SceneManager.LoadScene("SwipeMenu");
    }

    public void ShowStudents()
    {
        SceneManager.LoadScene("ShowStudents");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void LoginStud()
    {
        SceneManager.LoadScene("LoginPhp");
    }
    public void LoginTeacher()
    {
        SceneManager.LoadScene("ProfLogin");
    }

    public void Admin()
    {
        SceneManager.LoadScene("Admin");
    }

    public void AdminCreare()
    {
        SceneManager.LoadScene("AdminCreare");
    }
    public void AdminStergere()
    {
        SceneManager.LoadScene("AdminStergere");
    }

    public void Welcome()
    {
        SceneManager.LoadScene("Welcome");
    }

    public void PlayQuiz()
    {
        SceneManager.LoadScene("PlayQuiz");
    } 
    public void Quiz()
    {
        SceneManager.LoadScene("Quizz");
    }

    public void Game()
    {
        SceneManager.LoadScene("GameMenu");
    }

    public void Joc()
    {
        SceneManager.LoadScene("Joc");
    }

    public void Cub()
    {
        SceneManager.LoadScene("Cub");

    }

    public void Paralelipiped()
    {
        SceneManager.LoadScene("Parleliiped");
    }

    public void ParalelipipedEx()
    {
        SceneManager.LoadScene("Paralelipiped");
    }

    public void Sfera()
    {
        SceneManager.LoadScene("Sfera");
    }

    public void Piramida()
    {
        SceneManager.LoadScene("Piramida");
    }

    public void ExCub()
    {
        SceneManager.LoadScene("Cub2");
    }

    public void ExCub2()
    {
        SceneManager.LoadScene("Cub3");
    }

    public void Conul()
    {
        SceneManager.LoadScene("Conul");
    }

    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void DoubleBack()
    {
        SceneManager.LoadScene("Quizz");
    }

    public void BackCub()
    {
        SceneManager.LoadScene("Cub");
    }

    public void Prof()
    {
        scenaCurenta = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("Scena salvata", scenaCurenta);
        SceneManager.LoadScene(4);
    }


    public void Logout()
    {
        scenaCurenta = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("Scena salvata", scenaCurenta);
        SceneManager.LoadScene(2);
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

}
