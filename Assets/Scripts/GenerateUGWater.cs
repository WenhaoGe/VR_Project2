using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateUGWater : MonoBehaviour {

    // Use this for initialization

	public GameObject water_cube;
   
    void Start ()
	{
        TextAsset txtAsset = (TextAsset)Resources.Load("raster_to_point", typeof(TextAsset));
        string[] lines = txtAsset.text.Split('\n');

        for(int index =1;index < lines.Length-1; index++)
        {
            string[] values = lines[index].Split(',');
            float longitude = float.Parse(values[2]);
            float latitude = float.Parse(values[3]);
            float thickness = float.Parse(values[1]);

			if (longitude >= -102.0156f && longitude <= -101.74713)
			{
				if (latitude >= 33.47297 && latitude <= 33.69849) 
				{
					float xPos = (longitude - -102.0156f) * 1862.28756f;
					float zPos = (latitude - 33.47297f) * 2217.098262f;
                    var point = Instantiate(water_cube, new Vector3(xPos, 59.5f, zPos), Quaternion.identity);
					//point.transform.localScale = new Vector3(5.0f, 0.0625f * thickness, 5.0f);
					point.transform.localScale = new Vector3(12.0f, 0.01905f * thickness, 12.0f);


					point.name = values [0];
				}
			}
        }
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}