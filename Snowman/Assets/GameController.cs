using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public UnityEngine.UI.Text Message;
    public UnityEngine.UI.Button StartButton;
    public GameObject StartScreen;
    public GameObject PlayScreen;


    public void StartGame()
    {
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
