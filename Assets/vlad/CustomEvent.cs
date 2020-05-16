using System.Collections.Generic;
using UnityEngine;

public class CustomEvent : MonoBehaviour {
    class CustomEventInfo {
        public string title;
        public string desc;
    }

    

    Dictionary<CustomEvent, CustomEventInfo> infos = new Dictionary<CustomEvent, CustomEventInfo>();

    public MyInputPopUp inputPopUp;

    public void OnClick() {
        CustomEventInfo info;
        infos.TryGetValue(this, out info);
        if (info == null) {
            info = new CustomEventInfo();
            infos.Add(this, info);
        }

        inputPopUp.eventTitle.onValueChanged.RemoveAllListeners();
        inputPopUp.eventDesc.onValueChanged.RemoveAllListeners();
        inputPopUp.eventTitle.onValueChanged.AddListener(delegate(string s) { info.title = s; });
        inputPopUp.eventDesc.onValueChanged.AddListener(delegate(string s) { info.desc = s; });
        inputPopUp.Open(info.title, info.desc);
    }
}