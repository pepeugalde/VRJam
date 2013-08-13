using UnityEngine;
using System.Collections;
 
public class StaringScript : MonoBehaviour 
{
	public RaycastHit raycastHit;
	
	private Collider staredObject;
	
	private int stareSec = 0;
	
    void Update() 
    {
		/*
        Vector3 CameraCenter = camera.ScreenToWorldPoint(new Vector3(Screen.width/2, Screen.height/2, camera.nearClipPlane));
        if (Physics.Raycast(CameraCenter, transform.up, 100))
            Debug.Log("Ou yeah!");
 		*/
		
		 //Variable which contains information of the gameobject the raycast hits.

		if(Physics.Raycast(transform.position, transform.forward, out raycastHit, 1000.0f)) //Sends out a really long raycast from the camera, and returns information to the variable we created. You can now use it to do something like.
		{
			Collider rhc = raycastHit.collider; //We defined a new variable and made it equal to the collider of whatever our raycast hit. We could also make an else statement with a debug.log like so.
			if (staredObject != rhc) {
            	staredObject = rhc;
				Debug.Log("NOW STARING AT: " + staredObject);
			} else {
				stareSec++;
			}
		} else {
			if (staredObject != null) {
				Debug.Log("STOPPED STARING AFTER: " + stareSec);
				staredObject = null;
				stareSec = 0;
			}
		}
		
		
		
    }
}