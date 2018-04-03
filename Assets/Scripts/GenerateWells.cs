using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateWells : MonoBehaviour {

    // Use this for initialization

	public GameObject water_well_prefab;
	public GameObject well_marker;
   
    void Start () {
        TextAsset txtAsset = (TextAsset)Resources.Load("data", typeof(TextAsset));
        string[] lines = txtAsset.text.Split('\n');
        Debug.Log(lines.Length);
        for(int index =1;index < lines.Length-1; index++)
        {
            string[] values = lines[index].Split(',');
            // Debug.Log(values);
            float longitude = float.Parse(values[2]);
            float latitude = float.Parse(values[3]);
			if (longitude >= -102.0156f && longitude <= -101.74713)
			{
				if (latitude >= 33.47297 && latitude <= 33.69849) 
				{
					float xPos = (longitude - -102.0156f) * 1862.28756f;
					float zPos = (latitude - 33.47297f) * 2217.098262f;
					var well = Instantiate(water_well_prefab, new Vector3 (xPos, 200f, zPos), Quaternion.identity);
					var marker = Instantiate(well_marker, new Vector3 (xPos, 250f, zPos), Quaternion.Euler(new Vector3(80,0,0)));
					well.name = values [0];
					var info = "Location: "+ longitude +", "+latitude+"\nCounty: "+values[4];
					var info2 = "\nMeasurement: " + values [5] + "/" + values [6] + "/" + values [7];
					var info3 = "\nWater Elevation: " + values [8] + "\nSaturatedThickness: " + values [9];

					/*

					Saturated Thickness data must be visualized on top of the water elevation gameobject
					Saturated Thickness data must change if it is raining, there is a drought, or it is neutral


					Buttons to make it rain or make drought

					Teletransportation

					Bottom layer					
		
					
					 */

					well.GetComponent<DisplayInfo> ().inFormation = info+info2+info3;
				}
			}
        }
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}