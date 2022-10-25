using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonTimers // Не смог реализовать
{
    private static SingletonTimers _instance;
    public static SingletonTimers Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new SingletonTimers();
            }
            return _instance;
        }
    }
    
    public void DecayTimer(float decayTime, ref bool decayTimerZero)
    {
        decayTime -= Time.deltaTime;
        if (decayTime <= 0)
            decayTimerZero = true;
    }

    public void EnrichmentTime(float _enrichmentTime, ref bool _enrichment)
    {
        _enrichmentTime -= Time.deltaTime;
        if (_enrichmentTime <= 0)
            _enrichment = false;
    }
}
