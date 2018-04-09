using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateWells : MonoBehaviour {

    // Use this for initialization
    // Created three gameobjects
	public GameObject water_well_prefab;
	public GameObject well_marker;
    public GameObject depth_object;
   
    void Start ()
	{
        TextAsset txtAsset = (TextAsset)Resources.Load("data", typeof(TextAsset));
        string[] lines = txtAsset.text.Split('\n');
        Debug.Log(lines.Length);
        print("Here");
        for(int index =1;index < lines.Length-1; index++)
        {
            string[] values = lines[index].Split(',');
            float longitude = float.Parse(values[2]);
            float latitude = float.Parse(values[3]);
            float elevation = float.Parse(values[8]);

			if (longitude >= -102.0156f && longitude <= -101.74713)
			{
				if (latitude >= 33.47297 && latitude <= 33.69849) 
				{
					float xPos = (longitude - -102.0156f) * 1862.28756f;
					float zPos = (latitude - 33.47297f) * 2217.098262f;

					var well = Instantiate(water_well_prefab, new Vector3 (xPos, 100f, zPos), Quaternion.identity);
					var marker = Instantiate(well_marker, new Vector3 (xPos, 150f, zPos), Quaternion.Euler(new Vector3(80,0,0)));
                    var depth = Instantiate(depth_object, new Vector3(xPos, -100f, zPos), Quaternion.identity);
					var acc = new Vector3(0.0f, -5.0f, 0.0f);
					depth.GetComponent<Rigidbody>().AddForce(-acc*500);

                    depth.transform.localScale = new Vector3(1.0f, 0.02f * elevation, 1.0f);

					well.name = values [0];
					marker.name = values[0]+"_marker";
					depth.name = values[0]+"_elevation";

					var info = "\nLocation: "+ longitude +", "+latitude+"\nCounty: "+values[4];
					var info2 = "\nMeasurement: " + values [5] + "/" + values [6] + "/" + values [7];
					var info3 = "\nWater Elevation: " + values [8] + "\nSaturatedThickness: " + values [9];

					well.GetComponent<DisplayInfo> ().inFormation = info+info2+info3;
				}
			}
        }
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}