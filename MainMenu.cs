using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int sceneToLoad;
   public void StartGame()
    {
        SceneManager.LoadScene(sceneToLoad);// Scene to Load
        Debug.Log("New Scene loaded!");

    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game!");
    }
}
