using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public static class WordButtonExt
{
    public static void AddEventListener<T> (this Button button, T param, Action<T> OnClick)
    {
        button.onClick.AddListener(delegate ()
        {
            OnClick(param);
        });
    }
}

public class DictionaryManager : MonoBehaviour
{
    public GameObject wordMenu;
    public Text _word;
    public Text _english;
    public Text _discription;
    public InputField searchInput;

    [System.Serializable]
    public struct Word
    {
        public string word;
        public string equalEnglish;
        public string discription;
    }

    [SerializeField] Word[] allWords;

    List<GameObject> allWordsButtons;

    void Start()
    {
        GameObject buttonWord = transform.GetChild(0).gameObject;
        GameObject w;

        allWordsButtons = new List<GameObject>();

        for(int i = 0; i < allWords.Length; i++)
        {
            w = Instantiate(buttonWord, transform);
            w.transform.GetChild(0).GetComponent<Text>().text = allWords[i].word;

            w.GetComponent<Button>().AddEventListener(i, WordClicked);

            allWordsButtons.Add(w);
        }

        Destroy(buttonWord);
    }

    void WordClicked(int i)
    {
        searchInput.text = "";
        _word.text = allWords[i].word;
        _english.text = allWords[i].equalEnglish;
        _discription.text = allWords[i].discription;
        wordMenu.SetActive(true);
    }

    void Update()
    {
        if (searchInput.text != "")
        {
            wordMenu.SetActive(false);
            checkWordsList();
        }
        else
        {
            for (int i = 0; i < allWords.Length; i++)
            {
                allWordsButtons[i].SetActive(true);
            }
         }
    }

    void checkWordsList()
    {
        for(int i = 0; i < allWords.Length; i++)
        {
            bool sameWord = true;
            for (int n = 0; n < searchInput.text.Length; n++)
            {
                if(allWords[i].word[n] != searchInput.text[n])
                {
                    sameWord = false;
                }
            }
            if (!sameWord)
            {
                allWordsButtons[i].SetActive(false);
            }
            else
            {
                allWordsButtons[i].SetActive(true);
            }
        }
    }
}
