using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] GameObject menuScreen;
    [SerializeField] GameObject leaderboardScreen;
    [SerializeField] TMP_InputField inputField;

    public void NameInput()
    {
        if (string.IsNullOrEmpty(inputField.text))
        {
            DataManager.currentName = "unknown";
        }
        else
        {
            DataManager.currentName = inputField.text;
        }
    }

    public void StartGame()
    {
        NameInput();
        SceneManager.LoadScene(1);
    }

    public void LeaderboardOn()
    {
        menuScreen.SetActive(false);
        leaderboardScreen.SetActive(true);
    }

    public void LeaderboardOff()
    {
        leaderboardScreen.SetActive(false);
        menuScreen.SetActive(true);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
