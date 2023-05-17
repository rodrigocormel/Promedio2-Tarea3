using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerUI : MonoBehaviour, ISubject
{
    private static GameManagerUI instance;
    private int playerLife;
    private int score;
    private int kills;
    public UIController uiController;

    public float PlayerLife { get { return playerLife; } }
    public float Score { get { return score; } }
    public float Kills { get { return kills; } }

    private void Awake()
    {
        instance = this;
    }

    public void Notify()
    {
        uiController.Execute(this);
    }

    public void UpdateScore()
    {
        kills++;
        score += 10;
        Notify();
    }


    public void UpdatePlayerLife(int value)
    {
        playerLife = value;
        Notify();
    }

    public void RestScore()
    {
        score -= 5;
        Notify();
    }

    public static GameManagerUI GetInstance()
    {
        return instance;
    }

    public void Attach(IObserver observer)
    {
        
    }
    public void Remove(IObserver observer)
    {
       
    }
}
