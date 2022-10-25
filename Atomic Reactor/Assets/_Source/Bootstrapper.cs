using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    public UITimer UITimer;
    public ResourceControleButton[] Controle;
    public GameObject LosePanel;
    
    private Game _game;
    void Start()
    {
        _game = new Game();
        _game.StartGame();
    }

    void Update()
    {
        if (_game.GameWork)
            UITimer.GameTimer();

        for (int i = 0; i < Controle.Length; i++)
        {
            if (Controle[i].DecayTimerZero)
            {
                _game.EndGame(LosePanel);
            }
        }
    }
}
