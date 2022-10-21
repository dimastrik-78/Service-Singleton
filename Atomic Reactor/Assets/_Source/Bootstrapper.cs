using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    public UITimer UITimer;
    
    private Game game;
    void Start()
    {
        game = new Game();
        game.StartGame();
    }

    void Update()
    {
        UITimer.GameTimer(game.GameWork);
    }
}
