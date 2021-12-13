using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CompleteOne : MonoBehaviour
{
    //set button function
    public void RestartGame1()
    {
                KillCounterScript.killCount = 0; //restarts the kill count

      SceneManager.LoadScene("Level1"); //loads level scenes
    }

    //set button function
    public void NextGame2()
    {
                KillCounterScript.killCount = 0; //restarts the kill count

        SceneManager.LoadScene("Level2");//loads level scenes
    }

    //set button function
    public void MainMenu1()
    {
        SceneManager.LoadScene("Menu");//loads level scenes
    }
}
