using System.Collections;
using System.Collections.Generic;
using ResourcesSystem;
using UnityEngine;

public class SingletonTimerEnrichmentAndDecay
{
    private static SingletonTimerEnrichmentAndDecay _instance;
    public static SingletonTimerEnrichmentAndDecay Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new SingletonTimerEnrichmentAndDecay();
            }
            return _instance;
        }
    }
    
    private EnrichmentAndDecayTimes _resourceTime;
    
    public void TimerOutput(RadioactiveResourcesType resourcesType, ref float enrichmentTime, ref float decayTime)
    {
        _resourceTime = Resources.Load("EnrichmentAndDecayTimes") as EnrichmentAndDecayTimes;
        
        for (int i = 0; i < _resourceTime.EnrichmentAndDecayTimeList.Count; i++)
        {
            if (_resourceTime.EnrichmentAndDecayTimeList[i].ResourcesType == resourcesType)
            {
                enrichmentTime = _resourceTime.EnrichmentAndDecayTimeList[i].EnrichmentTime;
                decayTime = _resourceTime.EnrichmentAndDecayTimeList[i].DecayTime;
            }
        }
    }
}
