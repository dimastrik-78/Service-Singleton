using System.Collections;
using System.Collections.Generic;
using ResourcesSystem;
using UnityEngine;
using UnityEngine.UI;

public class SingletonIcon
{
    private static SingletonIcon instance;

    public static SingletonIcon Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new SingletonIcon();
            }
            return instance;
        }
    }
    
    private RadioactiveResource _resource;

    public void EnabledResource(RadioactiveResourcesType resourcesType, Image icon)
    {
        _resource = Resources.Load("RadioactiveResources") as RadioactiveResource;

        for (int i = 0; i < _resource.RadioactiveResourceList.Count; i++)
        {
            if (_resource.RadioactiveResourceList[i].ResourcesType == resourcesType)
            {
                icon.sprite = _resource.RadioactiveResourceList[i].EnabledIcon;
            }
        }
    }

    public void DisabledResource(RadioactiveResourcesType resourcesType, Image icon)
    {
        _resource = Resources.Load("RadioactiveResources") as RadioactiveResource;

        for (int i = 0; i < _resource.RadioactiveResourceList.Count; i++)
        {
            if (_resource.RadioactiveResourceList[i].ResourcesType == resourcesType)
            {
                icon.sprite = _resource.RadioactiveResourceList[i].DisabledIcon;
            }
        }
    }
}
