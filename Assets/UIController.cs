using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    private Button startButton;
    private Button messageButton;
    private Label messageText;
    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        startButton = root.Q<Button>("start-button");
        messageButton = root.Q<Button>("message-button");
        messageText = root.Q<Label>("message-text");

        startButton.clicked += StartButtonPressed;
        messageButton.clicked += MessageButtonPressed;
    }

    void StartButtonPressed()
    {
        SceneManager.LoadScene("Main");
    }

    void MessageButtonPressed()
    {
        messageText.text = "Tommy was experimnenting HERE (18/01/2022)";
        messageText.style.display = DisplayStyle.Flex;
    }
}
