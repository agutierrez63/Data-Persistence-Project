using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public InputField playerName;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        PlayerPrefs.SetString("CurrentName", playerName.text);
        MainManager.playerNameStr = playerName.text;
    }

    public void QuitGame()
    {
        Application.Quit();
        PlayerPrefs.DeleteAll();
    }
}
