using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

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

    private void OnDisable()
    {
        // Event-Listener entfernen (optional, aber empfohlen)
        var uiDocument = GetComponent<UIDocument>();
        var root = uiDocument.rootVisualElement;
        var playButton = root.Q<Button>("Play");
        var settingsButton = root.Q<Button>("Settings");
        var quitButton = root.Q<Button>("Quit");

        playButton.clicked -= StartGame;
        settingsButton.clicked -= OpenSettings;
        quitButton.clicked -= QuitGame;
    }

    private void StartGame()
    {
        // Deine Logik hier
        Debug.Log("Game wird gestartet!");
    }

    private void QuitGame()
    {
        Debug.Log("Game wird beendet!");
    }

    private void OpenSettings()
    {
        settingsMenu.SetActive(true);
        gameObject.SetActive(false);
        Debug.Log("Settings werden geöffnet");
    }
}
