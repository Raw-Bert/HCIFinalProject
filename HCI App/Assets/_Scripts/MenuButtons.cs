using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    //Name of the scene to switch to
    public string test;

    //Just the example test button, but this button stuff isd all pretty ez!
    public void _ButtonNameHere_OnClick()
    {
        //This just cvhanges the scene to whatever test is set as in the editor
        SceneManager.LoadScene(test, LoadSceneMode.Single);
    }
}
