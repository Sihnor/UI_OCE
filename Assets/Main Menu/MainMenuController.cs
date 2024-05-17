using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public enum Levels
{
    MainMenu = 0,
    Start,
    Settings,
    Quit
}
public class MainMenuController : MonoBehaviour
{
    [SerializeField] GameObject settingsMenu;

    private void OnEnable()
    {
        // UI-Dokument referenzieren
        var uiDocument = GetComponent<UIDocument>();
        var root = uiDocument.rootVisualElement;

        // Button-Element finden
        var playButton = root.Q<Button>("Play");
        var settingsButton = root.Q<Button>("Settings");
        var quitButton = root.Q<Button>("Quit");


        // Event-Listener hinzufügen
        playButton.clicked += StartGame;
        settingsButton.clicked += OpenSettings;
        quitButton.clicked += QuitGame;
    }

    //private void OnDisable()
    //{
    //    // Event-Listener entfernen (optional, aber empfohlen)
    //    var uiDocument = GetComponent<UIDocument>();
    //    var root = uiDocument.rootVisualElement;
    //    var playButton = root.Q<Button>("Play");
    //    var settingsButton = root.Q<Button>("Settings");
    //    var quitButton = root.Q<Button>("Quit");

    //    playButton.clicked -= StartGame;
    //    settingsButton.clicked -= OpenSettings;
    //    quitButton.clicked -= QuitGame;
    //}

    private void StartGame()
    {
        // Deine Logik hier
        LevelButton();
        Debug.Log("Game wird gestartet!");
    }

    private void QuitGame()
    {
#if UNITY_EDITOR
        // Exit Playmode in editor only
        EditorApplication.ExitPlaymode();
#endif

        // Close game
        Application.Quit();
        Debug.Log("Game wird beendet!");
    }

    private void OpenSettings()
    {
        settingsMenu.SetActive(true);
        gameObject.SetActive(false);
        Debug.Log("Settings werden geöffnet");
    }

    public void LevelButton()
    {
        SceneManager.LoadScene(1);
    }
}
