using UnityEngine;
using UnityEngine.UI;

public class Logic : MonoBehaviour
{
    public int scoreR = 0,scoreL = 0;
    public Text scoreTextR,scoreTextL,WinText;
    public GameObject WinScreen;
    public Rigidbody2D BallRb;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
        
    }
    public void addscoreR()
    {
        scoreR++;
        scoreTextR.text = scoreR.ToString();
        if(scoreR == 5)
        {
            WinR();
        }
    }
    public void addscoreL()
    {
        scoreL++;
        scoreTextL.text = scoreL.ToString();
        if(scoreL == 5)
        {
            WinL();
        }
    }
    public void WinR()
    {
      WinText.text = "Player Right Wins!";
      WinScreen.SetActive(true);

    }
    public void WinL()
    {
      WinText.text = "Player Left Wins!";
    WinScreen.SetActive(true);
    }

}
