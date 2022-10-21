using System.Collections;
using System.Collections.Generic;
using Resources;
using UnityEngine;

public class SingletonIcon
{
    // public RadioactiveResourcesData radioactiveResource = new RadioactiveResourcesData();
    
    private Object items;

    public void EnabledResource(RadioactiveResourcesType resourcesType)
    {
        // radioactiveResource
        // items = UnityEngine.Resources.LoadAll(@"Assets\_Presention\Resources\", typeof(RadioactiveResource)); //RadioactiveResources RadioactiveResource
        // items = UnityEngine.Resources.FindObjectsOfTypeAll(typeof(RadioactiveResource));
        // Debug.Log(items.Length);
        // radioactiveResource.ResourcesType = resourcesType;
        // Debug.Log(radioactiveResource.EnabledIcon);

        // items = Object.FindObjectOfType<RadioactiveResource>();
        // Debug.Log(items);
    }

    public void DisabledResource()
    {
        
    }
}
