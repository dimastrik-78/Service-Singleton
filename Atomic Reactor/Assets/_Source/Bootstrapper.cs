using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    [HideInInspector] public Game game;
    void Start()
    {
        game = new Game();
        game.StartGame();
    }

    void Update()
    {
        game.GameTimer();
    }
}
