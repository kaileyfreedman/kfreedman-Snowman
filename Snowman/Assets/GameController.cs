using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WordGuesser;

public class GameController : MonoBehaviour
{
    public UnityEngine.UI.Text Message;
    public UnityEngine.UI.Text GetWord;
    public UnityEngine.UI.Text GetGuessedLetters;
    public UnityEngine.UI.Text GuessesRemaining;
    public UnityEngine.UI.Text PlayerLost;

    public UnityEngine.UI.Text CheckGuess;
    public UnityEngine.UI.Button StartButton;
    public GameObject StartScreen;
    public GameObject PlayScreen;
    public GameObject GameOverScreen;

    private WordGuesser.WordGame guessingGame;
    public UnityEngine.UI.InputField PlayerGuess;

    public void SubmitGuess()
    {
        string guess = PlayerGuess.text;
        CheckGuess.text = this.guessingGame.CheckGuess(PlayerGuess.text);

        Debug.Log(guess);
        GetWord.text = this.guessingGame.GetWord();
        GetGuessedLetters.text = this.guessingGame.GetGuessedLetters();
        PlayerGuess.text = string.Empty;
    }

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

    public void ShowGameOverScreen()
    {
        PlayerLost.text = $"You lost. The word was: {this.guessingGame.GetFullWord()}";
        GameOverScreen.SetActive(true);
        this.StartScreen.SetActive(false);
        this.PlayScreen.SetActive(false);
        this.StartButton.gameObject.SetActive(true);
    }


    public void Start()
    {
        this.PlayScreen.SetActive(false);
        this.StartScreen.SetActive(true);
    }
}
