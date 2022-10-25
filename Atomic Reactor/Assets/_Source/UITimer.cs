using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITimer : MonoBehaviour
{
    public Text Timer;

    private float _gameTime;
    public void GameTimer()
    {
        _gameTime += Time.deltaTime;
        Timer.text = Math.Truncate(_gameTime).ToString();
    }
}
