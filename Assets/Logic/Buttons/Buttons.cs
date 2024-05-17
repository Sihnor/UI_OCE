using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;


public enum Levels
{
    MainMenu = 0,
    Start,
    Settings,
    Quit
}


public class Buttons : MonoBehaviour
{
    public void LevelButton(Levels level)
    {
        SceneManager.LoadScene((int)level);
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
        // Exit Playmode in editor only
        EditorApplication.ExitPlaymode();
        #endif

        // Close game
        Application.Quit();
    }
}
