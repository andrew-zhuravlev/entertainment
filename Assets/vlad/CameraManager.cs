using UnityEngine;

namespace vlad {
    public class CameraManager {
        CameraManager() {
            _arCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
            _mapCamera = GameObject.Find("MapCamera").GetComponent<Camera>();
        }
        static CameraManager _i = null;
        public static CameraManager I {
            get {
                if (_i == null) {
                    _i = new CameraManager();
                }

                return _i;
            }
        }
        
        public Camera GetCurrentCamera() {
            if (_mapCamera.enabled) {
                return _mapCamera;
            }

            return _arCamera;
        }

        readonly Camera _arCamera;
        readonly Camera _mapCamera;
    }
}