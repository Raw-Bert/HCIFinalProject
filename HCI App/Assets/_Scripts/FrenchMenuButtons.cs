using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FrenchMenuButtons : MonoBehaviour
{
    public string mainMenu;
    public string learnButton;
    public string dictionaryButton;
    public string profileButton;
    public string settings;

    public void HomeButton_OnClick()
    {
        SceneManager.LoadScene(mainMenu, LoadSceneMode.Single);
    }
    public void LearnButton_OnClick()
    {
        SceneManager.LoadScene(learnButton, LoadSceneMode.Single);
    }
    public void DictionButton_OnClick()
    {
        SceneManager.LoadScene(dictionaryButton, LoadSceneMode.Single);
    }
    public void ProfileButton_OnClick()
    {
        SceneManager.LoadScene(profileButton, LoadSceneMode.Single);
    }
    public void SettingsButton_OnClick()
    {
        SceneManager.LoadScene(settings, LoadSceneMode.Single);
    }
     public void ButtonTEST()
    {
        Debug.Log("WORD");
    }

}
