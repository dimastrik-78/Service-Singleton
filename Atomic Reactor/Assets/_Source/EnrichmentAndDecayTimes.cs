using System.Collections;
using System.Collections.Generic;
using Resources;
using UnityEngine;

[CreateAssetMenu(fileName = "NewRadioactiveResources", menuName = "SO/Enrichment And Decay Times")]
public class EnrichmentAndDecayTimes : ScriptableObject
{
    [SerializeField] private RadioactiveResourcesType resourcesType;
    [SerializeField] private float enrichmentTime;
    [SerializeField] private float decayTime;

    public RadioactiveResourcesType ResourcesType => resourcesType;
    public float EnrichmentTime => enrichmentTime;
    public float DecayTime => decayTime;
}
