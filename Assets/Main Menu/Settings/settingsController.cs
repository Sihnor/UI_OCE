using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class settingsController : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;

    private void OnEnable()
    {
        // UI-Dokument referenzieren
        var uiDocument = GetComponent<UIDocument>();
        var root = uiDocument.rootVisualElement;

        // Button-Element finden
        var returnButton = root.Q<Button>("Return");



        // Event-Listener hinzufügen
        returnButton.clicked += ReturnToMainMenu;
    }

    private void OnDisable()
    {
        // Event-Listener entfernen (optional, aber empfohlen)
        var uiDocument = GetComponent<UIDocument>();
        var root = uiDocument.rootVisualElement;
        var returnButton = root.Q<Button>("Return");

        returnButton.clicked -= ReturnToMainMenu;

    }

    private void ReturnToMainMenu()
    {
        mainMenu.SetActive(true);
        gameObject.SetActive(false);
        Debug.Log("Settings werden geschlossen");
    }
}
