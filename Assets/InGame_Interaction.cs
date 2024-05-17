using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.UIElements;

public class InGame_Interaction : MonoBehaviour
{
    private DropdownField DropdownField;
    private ProgressBar ProgressBar;
    private Foldout Foldout;
    private Button UseButton;
    private Button KillButton;

    [SerializeField] GameObject tempo;

    // Start is called before the first frame update
    void Start()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        
        this.DropdownField = root.Q<DropdownField>("QuestDropDown");
        this.ProgressBar = root.Q<ProgressBar>("QuestProgress");
        this.Foldout = root.Q<Foldout>("QuestFoldout");
        this.UseButton = root.Q<Button>("UseButton");
        this.KillButton = root.Q<Button>("KillButton");

        this.UseButton.clicked += Temp;

        this.DropdownField.choices.Add("Quest 1");
        this.DropdownField.choices.Add("Quest 2");
        this.DropdownField.choices.Add("Quest 3");
        
        this.Foldout.text = "Quests";
        this.Foldout.Add(new Label("Quest 1"));
        this.Foldout.Add(new Label("Quest 2"));
        this.Foldout.Add(new Label("Quest 3"));

        this.ProgressBar.value = 0;
        
        
        this.DropdownField.RegisterValueChangedCallback(evt =>
        {
            Debug.Log("Selected: " + evt.newValue);
        });
        
        GameManager.Instance.QuestProgress += progress =>
        {
            this.ProgressBar.value = progress;
        };

        
    }

    void Temp()
    {
        tempo.SetActive(true);
    }
}
