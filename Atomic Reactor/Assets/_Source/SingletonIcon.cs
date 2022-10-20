using System.Collections;
using System.Collections.Generic;
using Resources;
using UnityEngine;

public class SingletonIcon
{
    public RadioactiveResourcesData radioactiveResource = new RadioactiveResourcesData();
    
    private Object[] items;

    public void EnabledResource(RadioactiveResourcesType resourcesType)
    {
        // radioactiveResource
        items = UnityEngine.Resources.LoadAll(@"Assets\_Presention\Resources\", typeof(RadioactiveResourcesType));
        Debug.Log(items);
    }

    public void DisabledResource()
    {
        
    }
}
