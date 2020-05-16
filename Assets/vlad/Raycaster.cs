using JetBrains.Annotations;
using Lean.Gui;
using UnityEngine;
using vlad;

public class Raycaster : MonoBehaviour {
    public LayerMask layerMask;
    public MyPopUp popUp;
    public MyInputPopUp inputPopUp;
    public GameObject eventPrefab;
    Ray _ray;
    RaycastHit _hit;

    Plane _hPlane = new Plane(Vector3.up, Vector3.zero);

    bool IsUiMode {
        get { return popUp.IsOpened() || inputPopUp.IsOpened(); }
    }

    bool _isCreateEvent = false;

    void Update() {
        if (IsUiMode) {
            return;
        }

        Camera cam = CameraManager.I.GetCurrentCamera();
        _ray = cam.ScreenPointToRay(Input.mousePosition);        
        
        if (Input.GetMouseButtonDown(0)) {
            if (_isCreateEvent) {
                float distance = 0;
                if (_hPlane.Raycast(_ray, out distance)) {
                    //temp.transform.position = 
                    GameObject e = Instantiate(eventPrefab, _ray.GetPoint(distance),
                        Quaternion.identity);
                }

                _isCreateEvent = false;
            }
            
            else if (Physics.Raycast(_ray, out _hit, Mathf.Infinity, layerMask)) {
                MyPoi myPoi = _hit.transform.parent.GetComponent<MyPoi>();
                if (myPoi != null) {
                    popUp.Open(myPoi.myInfo);
                }
                CustomEvent customEvent = _hit.transform.parent.GetComponent<CustomEvent>();
                if (customEvent != null) {
                    customEvent.inputPopUp = inputPopUp;
                    customEvent.OnClick();
                }
            }
        }
    }

    [UsedImplicitly]
    public void OnCreateEventClick() {
        Camera cam = CameraManager.I.GetCurrentCamera();
        if (cam == CameraManager.I.MapCamera) {
            _isCreateEvent = true;
        }
    }
}