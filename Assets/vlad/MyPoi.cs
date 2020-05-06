using System.Collections.Generic;
using Mapbox.Unity.MeshGeneration.Interfaces;
using UnityEngine;

public class MyPoi : MonoBehaviour, IFeaturePropertySettable {

    public struct PoiInfo {
        public Sprite sprite;
    }

    public PoiInfo myInfo = new PoiInfo();
    
    public void Set(Dictionary<string, object> props) {
        myInfo.sprite = transform.GetChild(0).GetComponent<SpriteRenderer>().sprite;
    }
}