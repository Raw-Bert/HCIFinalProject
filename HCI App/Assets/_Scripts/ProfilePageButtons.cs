using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ProfilePageButtons : MonoBehaviour
{
    public string backScene;

    //public GameObject achievementOneText;

    public void BackButton_OnClick()
    {
        SceneManager.LoadScene(backScene, LoadSceneMode.Single);
    }
}
