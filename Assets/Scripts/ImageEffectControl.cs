using UnityEngine;
using System.Collections;

//[AddComponentMenu("Image Effects/Blur/Blur")]
public class ImageEffectControl : MonoBehaviour {

	public Camera cam;
	public Camera cam2;
	BlurEffect bluri;
	bool blur;
	void Start () {
	 bluri= cam.gameObject.GetComponent<BlurEffect>();
		blur=false;
	}
	
	
	void Update () {
		//chacalazo del blur, cuando esten los assets hago un timer y reviso los parametros a configurar para que se vea chido(y no de un salto)
		if(blur && bluri.iterations<50){
			bluri.iterations+=1;
			
		} else if (!blur && bluri.iterations>=1){
			bluri.iterations-=1;
		}else if(bluri.iterations==0){
				
			cam2.CopyFrom(cam);
			cam.active=false;
			cam2.active=true;
		}
		//Copia el contenido de la camara activa en la otra camara inactiva, las intercambia y activa el blur
		if(Input.GetKeyDown(KeyCode.D) && !blur ){
			cam.CopyFrom(cam2);
			cam2.active=false;
			cam.active=true;
			blur=true;
			
		}else if(Input.GetKeyDown(KeyCode.D) && blur){
		
		
			blur=false;
		}
		
	}
}
