using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!"); //quit the game
        Application.Quit();
    }

    public void GitHub()
    {
        Application.OpenURL("https://github.com/AbelMel/Final_Version");
    }

}
