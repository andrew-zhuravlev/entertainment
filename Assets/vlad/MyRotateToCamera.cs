namespace vlad {
    using UnityEngine;

    public class MyRotateToCamera : MonoBehaviour {
        void Update() {
            Camera currentCamera = CameraManager.I.GetCurrentCamera();
            Quaternion cameraRot = currentCamera.transform.rotation;
            transform.LookAt(transform.position + cameraRot * Vector3.forward,
                cameraRot * Vector3.up);
        }
    }
}