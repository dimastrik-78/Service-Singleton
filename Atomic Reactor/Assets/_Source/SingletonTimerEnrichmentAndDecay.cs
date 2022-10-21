using System.Collections;
using System.Collections.Generic;
using ResourcesSystem;
using UnityEngine;

public class SingletonTimerEnrichmentAndDecay
{
    private static SingletonTimerEnrichmentAndDecay instance;
    public static SingletonTimerEnrichmentAndDecay Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new SingletonTimerEnrichmentAndDecay();
            }
            return instance;
        }
    }
    
    private EnrichmentAndDecayTimes items;
    private EnrichmentAndDecayTimes _resource;
    public void TimerOutput(RadioactiveResourcesType resourcesType)
    {
        items = Resources.Load("EnrichmentAndDecayTimes") as EnrichmentAndDecayTimes;
        
        
    }
}
