using Lean.Gui;
using UnityEngine;
using UnityEngine.UI;

public class MyPopUp : MonoBehaviour {
    public Image image;
    public LeanWindow window;
    
    public void Open(Sprite sprite) {
        image.sprite = sprite;
        
        window.TurnOn();
    }

    public bool IsOpened() {
        return window.On;
    }
}