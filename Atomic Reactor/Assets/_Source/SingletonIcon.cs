using System.Collections;
using System.Collections.Generic;
using ResourcesSystem;
using UnityEngine;
using UnityEngine.UI;

public class SingletonIcon
{
    private static SingletonIcon _instance;

    public static SingletonIcon Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new SingletonIcon();
            }
            return _instance;
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
