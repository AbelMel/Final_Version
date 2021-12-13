using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CompleteTwo : MonoBehaviour
{
    //set button function
    public void RestartGame2()
    {
        KillCounterScript.killCount = 0; //kill count reset
      SceneManager.LoadScene("Level2"); //load level scene
    }

        //set button function

    public void NextGame3()
    {
                KillCounterScript.killCount = 0;//kill count reset

        SceneManager.LoadScene("Level1");//load level scene
    }

    //set button function
    public void MainMenu2()
    {
        SceneManager.LoadScene("Menu");//load level scene
    }
}
