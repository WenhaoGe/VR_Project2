using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateWells : MonoBehaviour {

    // Use this for initialization
<<<<<<< HEAD

	public GameObject water_well;
	public Sprite well_marker;
=======
    // Created three gameobjects
	public GameObject water_well_prefab;
	public GameObject well_marker;
>>>>>>> 9ddf2c21eebba7b5845d9a92a7d56a6c3e801b29
    public GameObject depth_object;
	public GameObject water_cyl;
	public GameObject container_cube;
   
    void Start ()
	{
<<<<<<< HEAD
		TextAsset txtAsset = (TextAsset)Resources.Load("Lubbock_optimized", typeof(TextAsset));
		string[] lines = txtAsset.text.Split('\n');
		float scale = 0.0625f;

=======
        TextAsset txtAsset = (TextAsset)Resources.Load("data", typeof(TextAsset));
        string[] lines = txtAsset.text.Split('\n');
        Debug.Log(lines.Length);
        print("Here");
>>>>>>> 9ddf2c21eebba7b5845d9a92a7d56a6c3e801b29
        for(int index =1;index < lines.Length-1; index++)
        {
            string[] values = lines[index].Split(',');
			float longitude,latitude,well_depth,thickness,water_el,land_el;
			latitude = float.Parse(values[2]);
			longitude = float.Parse(values[3]);
			well_depth = float.Parse(values[4]);
			land_el = float.Parse(values[5]);
			water_el = float.Parse(values[6]);
			thickness = float.Parse(values[7]);
			//lsd = float.Parse(values[8]);

			if (longitude >= -101.9217f && longitude <= -101.83467)
			{
				if (latitude >= 33.54782 && latitude <= 33.62077)
				{
					float xPos = (longitude - -102.0156f) * 1862.28756f;
					float zPos = (latitude - 33.47297f) * 2217.098262f;

					var well = Instantiate(water_well, new Vector3 (xPos, scale*land_el+3.5f, zPos), Quaternion.identity);
					var container = Instantiate(container_cube, new Vector3 (xPos, scale*land_el+3.5f, zPos), Quaternion.identity);
					var marker = Instantiate(well_marker, new Vector3 (xPos, 150f, zPos), Quaternion.Euler(new Vector3(80,0,0)));
                    var depth = Instantiate(depth_object, new Vector3(xPos, scale*land_el , zPos), Quaternion.identity);
					var st = Instantiate(water_cyl, new Vector3(xPos, scale*water_el - (scale*thickness), zPos), Quaternion.identity);

                    depth.transform.localScale = new Vector3(1.0f, scale * well_depth, 1.0f);
					st.transform.localScale = new Vector3(5.0f, scale * thickness, 5.0f);

					well.name = values [0];
					container.name = values [0];
					marker.name = values[0]+"_marker";
<<<<<<< HEAD
					depth.name = values[0]+"_well";
					st.name = values[0]+"_st";
					var info1 = "\nLocation: "+ longitude +", "+latitude+"\nCounty: "+values[1];
					var info2 = "\nWell Depth: "+ well_depth +"\nLand Elevation: "+values[5];
					var info3 = "\nWater Elevation: " + values [6] + "\nSaturatedThickness: " + values [7];
					var info4 = "\nLast Measurement On: " + values [9] + "/" + values [10] + "/" + values[11];

					well.GetComponent<DisplayInfo> ().inFormation = info1+info2+info3+info4;
					container.GetComponent<DisplayInfo> ().inFormation = info1+info2+info3+info4;
=======
					depth.name = values[0]+"_elevation";

					var info = "\nLocation: "+ longitude +", "+latitude+"\nCounty: "+values[4];
					var info2 = "\nMeasurement: " + values [5] + "/" + values [6] + "/" + values [7];
					var info3 = "\nWater Elevation: " + values [8] + "\nSaturatedThickness: " + values [9];
>>>>>>> 9ddf2c21eebba7b5845d9a92a7d56a6c3e801b29

				}
			}
        }
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}