using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{

    public string question;
    public string answer;

    public TextMeshProUGUI questionText;

    public TextMeshProUGUI correctText;
    public TextMeshProUGUI incorrectText;

    public bool correct = false;
    public bool incorrect = false;


    public string activeAnswer = null;


    // Start is called before the first frame update
    void Start()
    {
        questionText.text = question;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPress()
    {
        activeAnswer = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.GetComponentInChildren<TextMeshProUGUI>().text;

        Debug.Log(activeAnswer);
        if (activeAnswer != null)
        {
            if (activeAnswer == answer)
            {
                correct = true;
                correctText.gameObject.SetActive(true);
            }
            else
            {   
                incorrect = true;
                incorrectText.gameObject.SetActive(true);
            } 
        }
        Debug.Log (correct + " <> " + incorrect);
    }
}
