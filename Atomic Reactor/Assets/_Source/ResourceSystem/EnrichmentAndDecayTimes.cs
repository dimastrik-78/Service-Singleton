using System;
using System.Collections;
using System.Collections.Generic;
using ResourcesSystem;
using UnityEngine;

namespace ResourcesSystem
{
    [CreateAssetMenu(fileName = "NewRadioactiveResources", menuName = "SO/Enrichment And Decay Times")]
    public class EnrichmentAndDecayTimes : ScriptableObject
    {
        [SerializeField] private List<EnrichmentAndDecayTimeData> enrichmentAndDecayTimeList;
        public List<EnrichmentAndDecayTimeData> EnrichmentAndDecayTimeList => enrichmentAndDecayTimeList;
    }

    [Serializable]
    public class EnrichmentAndDecayTimeData
    {
        [SerializeField] private RadioactiveResourcesType resourcesType;
        [SerializeField] private float enrichmentTime;
        [SerializeField] private float decayTime;

        public RadioactiveResourcesType ResourcesType => resourcesType;
        public float EnrichmentTime => enrichmentTime;
        public float DecayTime => decayTime;
    }
}
