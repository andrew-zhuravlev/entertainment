using UnityEngine;

public class Raycaster : MonoBehaviour {
    public Camera cam;
    public LayerMask layerMask;
    public MyPopUp popUp;
    Ray _ray;
    RaycastHit _hit;
    
    bool IsUiMode {
        get { return popUp.IsOpened(); }
    }

    void Update() {
        if (IsUiMode) {
            return;
        }

        _ray = cam.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButtonDown(0)) {
            if (Physics.Raycast(_ray, out _hit, Mathf.Infinity, layerMask)) {
                MyPoi myPoi = _hit.transform.parent.GetComponent<MyPoi>();
                if (myPoi != null) {
                    popUp.Open(myPoi.myInfo);
                }
            }
        }
    }
}