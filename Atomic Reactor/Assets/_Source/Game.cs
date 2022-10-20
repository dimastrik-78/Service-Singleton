using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game
{
    private bool _goTimer;
    public float GameTime;
    public void StartGame()
    {
        _goTimer = true;
    }

    public void GameTimer()
    {
        if (_goTimer) GameTime += Time.deltaTime;
    }

    public void EndGame()
    {
        _goTimer = false;
    }
}
