﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateWells : MonoBehaviour {

    // Use this for initialization
   
    void Start () {
        TextAsset txtAsset = (TextAsset)Resources.Load("data", typeof(TextAsset));
        string[] lines = txtAsset.text.Split('\n');
        Debug.Log(lines.Length);
        for(int index =1;index < lines.Length-1; index++)
        {
            string[] values = lines[index].Split(',');
            Debug.Log(values);
            float longitude = float.Parse(values[2]);
            float latitude = float.Parse(values[3]);
			if (longitude >= -102.0156f && longitude <= -101.74713)
			{
				if (latitude >= 33.47297 && latitude <= 33.69849) 
				{
					GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
					cube.name = values[0];
					float xPos = (longitude - -102.0156f) * 1862.28756f;
					float zPos = (latitude - 33.47297f) * 2217.098262f;
					cube.transform.position = new Vector3 (xPos, 110f, zPos);
					cube.AddComponent<DisplayInfo> ();
					cube.GetComponent<DisplayInfo> ().inFormation = "X: " + values [1] + " Y: " + values [2] + " Z: " + values [3];
				}
			}
        }
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}