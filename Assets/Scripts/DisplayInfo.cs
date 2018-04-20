using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayInfo : MonoBehaviour
{
    public bool isClicked = false;
    public string inFormation = "Depth: 6,374 meters";
    //private Button box;
    private Text t;

    void Start ()
    {
        t = GameObject.Find("Info").GetComponentInChildren<Text>();
        //box.enabled = false;
        t.enabled = false;

        if (gameObject.GetComponent<BoxCollider>() == null)
            gameObject.AddComponent<BoxCollider>();
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnMouseOver()
    {
        //box.SetActive(true);
        t.enabled = true;
        t.text = inFormation;
    }

    void OnMouseExit()
    {
        t.enabled = false;
        //box.SetActive(false);
    }
}
