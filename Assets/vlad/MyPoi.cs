using System.Collections.Generic;
using Mapbox.Unity.MeshGeneration.Interfaces;
using UnityEngine;

public class MyPoi : MonoBehaviour, IFeaturePropertySettable {
    public class PoiInfo {
        public Sprite poiSprite;
        public Sprite makiSprite;
        public string type = "";
        public string name = "";
    }

    public PoiInfo myInfo = new PoiInfo();

    public void Set(Dictionary<string, object> props) {
        myInfo.poiSprite = transform.GetChild(0).GetComponent<SpriteRenderer>().sprite;

        if (props.ContainsKey("name")) {
            myInfo.name = props["name"].ToString();
        }

        if (props.ContainsKey("type")) {
            myInfo.type = props["type"].ToString();
        }

        if (props.ContainsKey("maki")) {
            myInfo.makiSprite = Resources.Load<Sprite>("maki/" + props["maki"].ToString() + "-15");
        }
    }
}