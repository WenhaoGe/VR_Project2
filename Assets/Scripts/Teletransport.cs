using System.Collections;
using System.Collections.Generic;
 using UnityEngine;
 
 public class Teletransport : MonoBehaviour {
     public Camera top_cam;
     public Camera bot_cam;
 
     void Start() {
         top_cam.enabled = true;
		 bot_cam.enabled = false;    
     }
 
     public void SwitchCam () {
     top_cam.enabled = !top_cam.enabled;
     bot_cam.enabled = !bot_cam.enabled;
 	}
	 
 }