using System;
using System.Collections;
using System.Collections.Generic;
using ResourcesSystem;
using UnityEngine;
using UnityEngine.UI;

public class ResourceControleButton : MonoBehaviour
{
    public RadioactiveResourcesType ResourcesType;

    private EnrichmentAndDecayTimes _resourceTime;
    private static float enrichmentTime;
    private static float decayTime;

    public void Awake()
    {
        _resourceTime = Resources.Load("EnrichmentAndDecayTimes") as EnrichmentAndDecayTimes;
        
        for (int i = 0; i < _resourceTime.EnrichmentAndDecayTimeList.Count; i++)
        {
            if (_resourceTime.EnrichmentAndDecayTimeList[i].ResourcesType == ResourcesType)
            {
                enrichmentTime = _resourceTime.EnrichmentAndDecayTimeList[i].EnrichmentTime;
                decayTime = _resourceTime.EnrichmentAndDecayTimeList[i].DecayTime;
            }
        }
    }

    public void Test()
    {
        SingletonIcon.Instance.EnabledResource(ResourcesType, gameObject.GetComponent<Image>());
    }
}
