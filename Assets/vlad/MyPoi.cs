using System.Collections.Generic;
using Mapbox.Unity.MeshGeneration.Interfaces;
using UnityEngine;

public class MyPoi : MonoBehaviour, IFeaturePropertySettable {
    public class PoiInfo {
        public Sprite sprite;
        public string type = "";
        public string name = "";
    }

    public PoiInfo myInfo = new PoiInfo();

    public void Set(Dictionary<string, object> props) {
        myInfo.sprite = transform.GetChild(0).GetComponent<SpriteRenderer>().sprite;

        if (props.ContainsKey("name")) {
            myInfo.name = props["name"].ToString();
        }

        if (props.ContainsKey("type")) {
            myInfo.type = props["type"].ToString();
        }
    }
}