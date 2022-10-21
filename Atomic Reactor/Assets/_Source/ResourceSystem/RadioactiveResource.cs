using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace ResourcesSystem
{
    [CreateAssetMenu(fileName = "NewRadioactiveResources", menuName = "SO/New Radioactive Resources Data")]
    public class RadioactiveResource : ScriptableObject
    {
        [SerializeField] private List<RadioactiveResourcesData> radioactiveResourceList;
        public List<RadioactiveResourcesData> RadioactiveResourceList => radioactiveResourceList;
    }
    
    [Serializable]
    public class RadioactiveResourcesData
    {
        [SerializeField] private RadioactiveResourcesType resourcesType;
        [SerializeField] private Sprite enabledIcon;
        [SerializeField] private Sprite disabledIcon;

        public RadioactiveResourcesType ResourcesType => resourcesType;
        public Sprite EnabledIcon => enabledIcon;
        public Sprite DisabledIcon => disabledIcon;
    }
}
