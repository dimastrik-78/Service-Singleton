using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game
{
    public bool GameWork;
    public void StartGame()
    {
        GameWork = true;
    }

    public void EndGame(GameObject losePanel)
    {
        GameWork = false;
        
        losePanel.SetActive(true);
    }
}
