using UnityEngine;
using System.Collections;

//[AddComponentMenu("Image Effects/Blur/Blur")]
public class ImageEffectControl : MonoBehaviour {

	public Camera camarablur;
	public Camera camaranormal;
	BlurEffect blurefecto;
	bool bluractivo;
	
	void Start () {
	 blurefecto= camarablur.gameObject.GetComponent<BlurEffect>();
	 bluractivo=false;
	}
	
	
	void Update () {
		//chacalazo del blur, cuando esten los assets hago un timer y reviso los parametros a configurar para que se vea chido(y no de un salto)
		if(bluractivo && blurefecto.iterations<50){
			blurefecto.iterations+=1;
			
		} else if (!bluractivo && blurefecto.iterations>=1){
			blurefecto.iterations-=1;
		}else if(blurefecto.iterations==0 && camarablur.active){
				
			camaranormal.CopyFrom(camarablur);
			camarablur.active=false;
			camaranormal.active=true;
		}
		//Copia el contenido de la camara activa en la otra camara inactiva, las intercambia y activa el blur
		if(Input.GetKeyDown(KeyCode.D) && !bluractivo ){
			camarablur.CopyFrom(camaranormal);
			camaranormal.active=false;
			camarablur.active=true;
			bluractivo=true;
			
		}else if(Input.GetKeyDown(KeyCode.D) && bluractivo){
		
		
			bluractivo=false;
		}
		
	}
}
