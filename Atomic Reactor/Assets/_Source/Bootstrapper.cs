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
    private static SingletonIcon instance;

    public static SingletonIcon Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new SingletonIcon();
            }

            return instance;
        }
    }

    void Update()
    {
        game.GameTimer();
    }
}
