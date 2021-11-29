using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WordGuesser;

public class GameController : MonoBehaviour
{
    public UnityEngine.UI.Text Message;
    public UnityEngine.UI.Button StartButton;
    public GameObject StartScreen;
    public GameObject PlayScreen;
    private WordGuesser.WordGame guessingGame;


    public void StartGame()
    {
        this.guessingGame = new WordGuesser.WordGame("apple", 5);
        Debug.Log(this.guessingGame.GetWord());
        Debug.Log(this.guessingGame.GetFullWord());

        this.StartScreen.SetActive(false);
        this.PlayScreen.SetActive(true);
    }

    public void OpenStartScreen()
    {
        this.PlayScreen.SetActive(false);
        this.StartScreen.SetActive(true);
    }
   
   public void Start()
   {
        this.PlayScreen.SetActive(false);
        this.StartScreen.SetActive(true);
    }
}
