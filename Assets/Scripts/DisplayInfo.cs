using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayInfo : MonoBehaviour {
    public bool isClicked = false;
    public string inFormation = "";
        // Use this for initialization
    void Start () {
        if (gameObject.GetComponent<BoxCollider>() == null)
            gameObject.AddComponent<BoxCollider>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnMouseDown()
    {
        isClicked = true;
    }

    public void OnMouseUp()
    {
        isClicked = false;
    }

    public void OnGUI()
    {
        if (isClicked)
        {
            GUI.Label(new Rect(5, 5, 400, 100), "Well ID: " + this.name + "\n"+ this.inFormation);

			/*
			 * 
			 * API No.: 15-077-22002
			 * Lease: Dilbert SWD 3306
			 * Operator: SandRidge Exploration and Production LLC km
			 * Drilled: 1/1/2014
			 * Completed: 3/29/2014
			 * Status: Authorized Injection Well
			 * Depth: 6,374 meters
			 * 
			 * 
            */
        }
           
    }
}
