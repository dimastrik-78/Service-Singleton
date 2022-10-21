using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonTimerEnrichmentAndDecay
{
    private Object[] items;
    private EnrichmentAndDecayTimes _resource;
    
    
    
    private void GettingResource()
    {
        items = UnityEngine.Resources.LoadAll("RadRes", typeof(EnrichmentAndDecayTimes));
        _resource = (EnrichmentAndDecayTimes)items[0];
    }
}
