using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Resources
{
    [CreateAssetMenu(fileName = "NewRadioactiveResources", menuName = "SO/New Radioactive Resources Data")]
    public class RadioactiveResource : ScriptableObject
    {
        // [SerializeField] private List<RadioactiveResourcesData> radioactiveResource;
        public List<RadioactiveResourcesData> radioactiveResource;
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
