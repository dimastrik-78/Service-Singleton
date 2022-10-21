using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITimer : MonoBehaviour
{
    public Bootstrapper Bootstrapper;
    public Text Timer;

    private float GameTime;
    void Update()
    {
        Timer.text = Math.Truncate(GameTime).ToString();
    }
    public void GameTimer(bool gameWork)
    {
        if (gameWork) GameTime += Time.deltaTime;
    }
}
