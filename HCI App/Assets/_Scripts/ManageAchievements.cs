using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManageAchievements : MonoBehaviour
{
    public GameObject ach_1Info;
    public GameObject ach_2Info;
    public GameObject ach_3Info;
    public GameObject ach_4Info;

    void OnMouseOver() 
    {
        if(this.tag == "Ach_1")
        {
            Debug.Log("Fade IN Achievement 1 name + description");
        }
        else if(this.tag == "Ach_2")
        {
            Debug.Log("Fade IN Achievement 2 name + description");
        }
        else if(this.tag == "Ach_3")
        {
            Debug.Log("Fade IN Achievement 3 name + description");
        }
        else if(this.tag == "Ach_4")
        {
            Debug.Log("Fade IN Achievement 4 name + description");
        }
    }

    void OnMouseExit()
    {
        if(this.tag == "Ach_1")
        {
            Debug.Log("Fade OUT Achievement 1 name + description");
        }
        else if(this.tag == "Ach_2")
        {
            Debug.Log("Fade OUT Achievement 2 name + description");
        }
        else if(this.tag == "Ach_3")
        {
            Debug.Log("Fade OUT Achievement 3 name + description");
        }
        else if(this.tag == "Ach_4")
        {
            Debug.Log("Fade OUT Achievement 4 name + description");
        }
    }
}

