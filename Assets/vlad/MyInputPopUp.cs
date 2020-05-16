using System.Collections;
using System.Collections.Generic;
using Lean.Gui;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MyInputPopUp : MonoBehaviour {
    public LeanWindow window;
    public TMP_InputField eventTitle;
    public TMP_InputField eventDesc;

    public void Open(string title, string desc) {
        eventTitle.text = title;
        eventDesc.text = desc;

        window.TurnOn();
    }

    public bool IsOpened() {
        return window.On;
    }
}
