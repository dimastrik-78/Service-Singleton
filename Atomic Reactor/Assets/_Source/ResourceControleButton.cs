using System;
using System.Collections;
using System.Collections.Generic;
using ResourcesSystem;
using UnityEngine;
using UnityEngine.UI;

public class ResourceControleButton : MonoBehaviour
{
    public RadioactiveResourcesType ResourcesType;

    public bool DecayTimerZero;

    private EnrichmentAndDecayTimes _resourceTime;
    
    private float _enrichmentTime;
    private float _decayTime;

    private bool _enrichment;
    private bool _end;
    private void Start()
    {
        ActiveResource();
    }

    private void Update()
    {
        if (!_enrichment && !DecayTimerZero)
            DecayTimer();
        else if (!DecayTimerZero)
            EnrichmentTimer();
        
        // попытка реализовать таймер для задания на *
        // if (!_enrichment)
        //     SingletonTimers.Instance.DecayTimer(_decayTime, ref DecayTimerZero);
        // else
        // {
        //     SingletonTimers.Instance.EnrichmentTime(_enrichmentTime, ref _enrichment);
        //     if (!_enrichment)
        //         ActiveResource();
        // }
    }

    private void ActiveResource()
    {
        _enrichment = false;
        
        gameObject.GetComponent<Button>().interactable = true;
        
        SingletonIcon.Instance.EnabledResource(ResourcesType, gameObject.GetComponent<Image>());
        
        SingletonTimerEnrichmentAndDecay.Instance.TimerOutput(ResourcesType, ref _enrichmentTime, ref _decayTime);
    }
    
    private void DecayTimer()
    {
        _decayTime -= Time.deltaTime;
        if (_decayTime <= 0)
            DecayTimerZero = true;
    }
    
    private void EnrichmentTimer()
    {
        _enrichmentTime -= Time.deltaTime;
        if (_enrichmentTime <= 0)
            ActiveResource();
    }

    public void StartEnrichment()
    {
        _enrichment = true;
        
        SingletonIcon.Instance.DisabledResource(ResourcesType, gameObject.GetComponent<Image>());
        
        gameObject.GetComponent<Button>().interactable = false;
    }
}
