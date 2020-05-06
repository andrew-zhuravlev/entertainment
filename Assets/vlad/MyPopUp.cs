using Lean.Gui;
using UnityEngine;
using UnityEngine.UI;

public class MyPopUp : MonoBehaviour {
    public Image image;
    public Text nameText;
    public Text typeText;
    public LeanWindow window;

    public void Open(Sprite sprite, string name, string type) {
        image.sprite = sprite;
        nameText.text = name;
        typeText.text = type;

        window.TurnOn();
    }

    public bool IsOpened() {
        return window.On;
    }
}