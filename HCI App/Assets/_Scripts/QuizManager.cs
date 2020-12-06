using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{

    public GameObject Q1;
    public GameObject Q2;
    public GameObject Q3;
    public GameObject activeQ;
    public GameObject manager;

    public GameObject homeUI;



    public string back;

    // Start is called before the first frame update
    void Start()
    {
        Q1.SetActive(true);
        activeQ = Q1;
        StartCoroutine(WaitCoroutine());
    }

    // Update is called once per frame
    void Update()
    {

        if(activeQ == Q1 && (Q1.GetComponent<Quiz>().correct == true || Q1.GetComponent<Quiz>().incorrect == true))
        {
            StartCoroutine(WaitCoroutine());
        }
        else if(activeQ == Q2 && (Q2.GetComponent<Quiz>().correct == true || Q2.GetComponent<Quiz>().incorrect == true))
        {
            StartCoroutine(WaitCoroutine());

        }
        else if(activeQ == Q3 && (Q3.GetComponent<Quiz>().correct == true || Q3.GetComponent<Quiz>().incorrect == true))
        {
            StartCoroutine(WaitCoroutine());

        }


    }

    IEnumerator WaitCoroutine()
    {

        if(activeQ == Q1 && (Q1.GetComponent<Quiz>().correct == true || Q1.GetComponent<Quiz>().incorrect == true))
        {
            yield return new WaitForSeconds(1.5f);
            Q1.SetActive(false);
            Q2.SetActive(true);
            activeQ = Q2;
            
        }
        else if(activeQ == Q2 && (Q2.GetComponent<Quiz>().correct == true || Q2.GetComponent<Quiz>().incorrect == true))
        {
            yield return new WaitForSeconds(1.5f);
            Q2.SetActive(false);
            Q3.SetActive(true);
            activeQ = Q3;

        }
        else if(activeQ == Q3 && (Q3.GetComponent<Quiz>().correct == true || Q3.GetComponent<Quiz>().incorrect == true))
        {
            yield return new WaitForSeconds(1.5f);
            Q3.SetActive(false);
            Q1.SetActive(true);
            homeUI.SetActive(true);
            activeQ = Q1;
            manager.SetActive(false);
            SceneManager.LoadScene(back, LoadSceneMode.Single);

        }

    }
}
