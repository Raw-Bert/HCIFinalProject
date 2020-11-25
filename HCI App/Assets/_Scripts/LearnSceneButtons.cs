using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LearnSceneButtons : MonoBehaviour
{
    public string back;

    public GameObject buttons;

    public void BackButton_OnClick()
    {
        SceneManager.LoadScene(back, LoadSceneMode.Single);
    }

    public void FoodButton_OnClick()
    {
        buttons.SetActive(false);
    }

    public void GreetingsButton_OnClick()
    {
        buttons.SetActive(false);
    }

    public void ActivitiesButton_OnClick()
    {
        buttons.SetActive(false);
    }

    public void HotelsButton_OnClick()
    {
        buttons.SetActive(false);
    }
}