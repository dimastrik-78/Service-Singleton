using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewRadioactiveResources", menuName = "SO/Enrichment And Decay Times")]
public class EnrichmentAndDecayTimes : ScriptableObject
{
    [SerializeField] private float enrichmentTime;
    [SerializeField] private float decayTime;

    public float EnrichmentTime => enrichmentTime;
    public float DecayTime => decayTime;
}
