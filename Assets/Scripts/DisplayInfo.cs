using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayInfo : MonoBehaviour
{
    public bool isClicked = false;
    public string inFormation = "Depth: 6,374 meters";

    void Start ()
    {
        if (gameObject.GetComponent<BoxCollider>() == null)
            gameObject.AddComponent<BoxCollider>();
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnMouseOver()
    {
        isClicked = true;
    }

    void OnMouseExit()
    {
        isClicked = false;
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
            GUI.backgroundColor = Color.blue;
            GUI.Button(new Rect(5, 5, 300, 150), "Well ID: " + this.name + this.inFormation);
            GUI.skin.button.alignment = TextAnchor.MiddleLeft;;
        }
           
    }
}
