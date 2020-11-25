using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsButtons : MonoBehaviour
{
    public string backScene;

    public void BackButton_OnClick()
    {
        SceneManager.LoadScene(backScene, LoadSceneMode.Single);
    }
}
