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
            GUI.Label(new Rect(5, 5, 400, 100), "This is " + this.name + " with Information: "+ this.inFormation);
            
        }
           
    }
}
