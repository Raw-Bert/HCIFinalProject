using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LearnSceneButtons : MonoBehaviour
{
    public string back;

    public GameObject buttons;
    public GameObject foodUI;
    public GameObject greetingUI;
    public GameObject activityUI;
    public GameObject hotelUI;
    public GameObject foodQuizUI;
    public GameObject greetQuizUI;
    public GameObject actiQuizUI;
    public GameObject hotelQuizUI;

    public void BackButton_OnClick()
    {
        SceneManager.LoadScene(back, LoadSceneMode.Single);
    }

    public void FoodButton_OnClick()
    {
        buttons.SetActive(false);
        foodUI.SetActive(true);
    }

    public void GreetingsButton_OnClick()
    {
        buttons.SetActive(false);
        greetingUI.SetActive(true);
    }

    public void ActivitiesButton_OnClick()
    {
        buttons.SetActive(false);
        activityUI.SetActive(true);
    }

    public void HotelsButton_OnClick()
    {
        buttons.SetActive(false);
        hotelUI.SetActive(true);
    }

    public void FoodQuiz_OnClick()
    {
        foodUI.SetActive(false);
        foodQuizUI.SetActive(true);
    }
    public void GreetingQuiz_OnClick()
    {
        greetingUI.SetActive(false);
        greetQuizUI.SetActive(true);
    }
    public void ActivityQuiz_OnClick()
    {
        activityUI.SetActive(false);
        actiQuizUI.SetActive(true);
    }
    public void HotelQuiz_OnClick()
    {
        hotelUI.SetActive(false);
        hotelQuizUI.SetActive(true);
    }
}