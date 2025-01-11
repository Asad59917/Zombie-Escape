using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void Play()
    {
        SceneManager.LoadScene("Level_1");
    
    }

    public void Lvl1()
    {
        SceneManager.LoadScene("Lvl1StartScene");

    }

    public void Lvl2()
    {
        SceneManager.LoadScene("Lvl2StartScene");

    }


    public void EnterLvl1()
    {
        SceneManager.LoadScene("Level_1");

    }

    public void EnterLvl2()
    {
        SceneManager.LoadScene("Level_2");

    }

    public void Exit()
    {
        Application.Quit();
    }
}
