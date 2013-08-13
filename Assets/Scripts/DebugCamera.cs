using UnityEngine;
using System.Collections;

public class DebugCamera : MonoBehaviour {
	
	public bool DEBUG_CAMERA;
	
	public Camera simpleCamera;
	public OVRCameraController ovrCamera;
	
	void useSimpleCamera () {
		
		simpleCamera.enabled = true;
		ovrCamera.enabled = false;
		
		Destroy (ovrCamera.gameObject);
		ovrCamera = null;
		
	}
	void useOVRCamera () {
		
		simpleCamera.enabled = false;
		ovrCamera.enabled = true;
		
		Destroy(simpleCamera.gameObject);
		simpleCamera = null;
		
	}
	
	void Awake () {
		
	}
	
	// Use this for initialization
	void Start () {
		if (DEBUG_CAMERA) {
			//-- usar camara default
			Debug.Log("USANDO CAMARA SIMPLE");
			
			useSimpleCamera();
			
		} else {
			Debug.Log("USANDO OCULUS");
			
			useOVRCamera();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		if (DEBUG_CAMERA) {
			//-- simpleCamera
			//Vector3 r = simpleCamera.transform.ToString();
			//Debug.Log("ROTATION: " + simpleCamera.transform.up);
				
			//if (ang.x > 270) {
			//	Debug.Log ("MIRANDO AL TECHO");
			//}
			
		} else {
			//-- oculus
			//Vector3 ang  = Vector3.zero;
			//bool can = ovrCamera.GetCameraOrientationEulerAngles(ref ang);
			//Debug.Log("EULER: " + can + " : " + ang);
			
		}
		
	}
	
	
}
