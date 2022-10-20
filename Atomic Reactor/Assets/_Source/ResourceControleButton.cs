using System.Collections;
using System.Collections.Generic;
using Resources;
using UnityEngine;

public class ResourceControleButton : MonoBehaviour
{
    public RadioactiveResourcesType radioactiveResourcesData;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Test()
    {
        // Debug.Log(radioactiveResourcesData);
        new SingletonIcon().EnabledResource(radioactiveResourcesData);
    }
}
