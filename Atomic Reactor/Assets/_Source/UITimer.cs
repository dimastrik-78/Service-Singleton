using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITimer : MonoBehaviour
{
    public Bootstrapper Bootstrapper;
    public Text Timer;
    void Update()
    {
        Timer.text = Math.Truncate(Bootstrapper.game.GameTime).ToString();
    }
}
