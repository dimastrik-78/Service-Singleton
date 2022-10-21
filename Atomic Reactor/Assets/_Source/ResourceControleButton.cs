using System.Collections;
using System.Collections.Generic;
using Resources;
using UnityEngine;
using UnityEngine.UI;

public class ResourceControleButton : MonoBehaviour
{
    public RadioactiveResourcesType radioactiveResourcesData;

    // public RadioactiveResource Res;
    // public RadioactiveResource radioactiveResourcesData;
    void Start()
    {
        
    }

    public void Test()
    {
        // Debug.Log(radioactiveResourcesData);
        new SingletonIcon().EnabledResource(radioactiveResourcesData, gameObject.GetComponent<Image>());
    }
}
