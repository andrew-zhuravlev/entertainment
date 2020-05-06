using Lean.Gui;
using UnityEngine;
using UnityEngine.UI;

public class MyPopUp : MonoBehaviour {
    public Image image;
    public Image maki;
    
    public Text nameText;
    public Text typeText;
    public LeanWindow window;

    public void Open(MyPoi.PoiInfo poiInfo) {
        image.sprite = poiInfo.poiSprite;
        nameText.text = poiInfo.name;
        typeText.text = poiInfo.type;
        maki.sprite = poiInfo.makiSprite;

        window.TurnOn();
    }

    public bool IsOpened() {
        return window.On;
    }
}