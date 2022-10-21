using System.Collections;
using System.Collections.Generic;
using Resources;
using UnityEngine;
using UnityEngine.UI;

public class SingletonIcon
{
    // public RadioactiveResourcesData radioactiveResource = new RadioactiveResourcesData();
    
    private Object[] items;
    private RadioactiveResource _resource;

    public void EnabledResource(RadioactiveResourcesType resourcesType, Image icon)
    {
        // radioactiveResource
        // items = UnityEngine.Resources.LoadAll(@"Assets\_Presention\Resources\", typeof(RadioactiveResource)); //RadioactiveResources RadioactiveResource
        // items = UnityEngine.Resources.FindObjectsOfTypeAll(typeof(RadioactiveResource));
        // Debug.Log(items.Length);
        // radioactiveResource.ResourcesType = resourcesType;
        // Debug.Log(radioactiveResource.EnabledIcon);

        GettingResource();

        for (int i = 0; i < _resource.radioactiveResource.Count; i++)
        {
            if (_resource.radioactiveResource[i].ResourcesType == resourcesType)
            {
                icon.sprite = _resource.radioactiveResource[i].EnabledIcon;
            }
        }
    }

    public void DisabledResource(RadioactiveResourcesType resourcesType, Image icon)
    {
        GettingResource();

        for (int i = 0; i < _resource.radioactiveResource.Count; i++)
        {
            if (_resource.radioactiveResource[i].ResourcesType == resourcesType)
            {
                icon.sprite = _resource.radioactiveResource[i].DisabledIcon;
            }
        }
    }

    private void GettingResource()
    {
        items = UnityEngine.Resources.LoadAll("RadRes", typeof(RadioactiveResource));
        _resource = (RadioactiveResource)items[0];
    }
}
