using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIGameOver : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    ScoreKeeper scoreKeeper;
    //static AudioPlayer instance;

    void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
        //ManageSingleton();
    }
    void Start()
    {
        scoreText.text = "You Scored:\n" + scoreKeeper.GetScore();
    }
    // void ManageSingleton()
    // {
    //     if (instance != null)
    //     {
    //         gameObject.SetActive(false);
    //         Destroy(gameObject);
    //     }
    //     else
    //     {
    //         instance = this;
    //         DontDerstroyOnLoad(gameObject);
    //     }
    // }

}
