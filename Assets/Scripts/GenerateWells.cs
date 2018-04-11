using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateWells : MonoBehaviour
{
	public GameObject water_well;
	public GameObject well_marker;
    public GameObject depth_object;
	public GameObject water_cyl;
	public GameObject container_cube;

	private List<GameObject> wells = new List<GameObject>();
	private List<GameObject> markers = new List<GameObject>();
	private List<GameObject> depths = new List<GameObject>();
	private List<GameObject> waters = new List<GameObject>();
	private List<GameObject> boxs = new List<GameObject>();
	private List<float> lsds = new List<float>();
	private List<float> sts = new List<float>();
	private List<float> deps = new List<float>();
	private List<float> les = new List<float>();
	private float scale;
   
    void Start ()
	{
		TextAsset txtAsset = (TextAsset)Resources.Load("Lubbock_optimized", typeof(TextAsset));
		string[] lines = txtAsset.text.Split('\n');
		scale = 0.0625f;

        for(int index =1;index < lines.Length-1; index++)
        {
            string[] values = lines[index].Split(',');
			float longitude,latitude,well_depth,thickness,water_el,land_el,lsd;
			latitude = float.Parse(values[2]);
			longitude = float.Parse(values[3]);
			well_depth = float.Parse(values[4]);
			land_el = float.Parse(values[5]);
			water_el = float.Parse(values[6]);
			thickness = float.Parse(values[7]);
			lsd = float.Parse(values[8]);

			if (longitude >= -101.9217f && longitude <= -101.83467)
			{
				if (latitude >= 33.54782 && latitude <= 33.62077)
				{
					float xPos = (longitude - -102.0156f) * 1862.28756f;
					float zPos = (latitude - 33.47297f) * 2217.098262f;

					var well = Instantiate(water_well, new Vector3 (xPos, scale*land_el+3.5f, zPos), Quaternion.identity);
					var box = Instantiate(container_cube, new Vector3 (xPos, scale*land_el+3.5f, zPos), Quaternion.identity);
					var marker = Instantiate(well_marker, new Vector3 (xPos, 100f, zPos), Quaternion.Euler(new Vector3(80,0,0)));
                    var depth = Instantiate(depth_object, new Vector3(xPos, scale*land_el , zPos), Quaternion.identity);
					var water = Instantiate(water_cyl, new Vector3(xPos, scale*water_el - (scale*thickness), zPos), Quaternion.identity);

                    depth.transform.localScale = new Vector3(1.0f, scale * well_depth, 1.0f);
					water.transform.localScale = new Vector3(5.0f, scale * thickness, 5.0f);
					marker.transform.localScale = new Vector3(10,10,10);

					well.name = values [0];
					box.name = values [0];
					marker.name = values[0]+"_marker";
					depth.name = values[0]+"_well";
					water.name = values[0]+"_st";

					var info1 = "\nLocation: "+ longitude +", "+latitude+"\nCounty: "+values[1];
					var info2 = "\nWell Depth: "+ well_depth +"\nLand Elevation: "+values[5];
					var info3 = "\nWater Elevation: " + values [6] + "\nSaturatedThickness: " + values [7];
					var info4 = "\nLast Measurement On: " + values [9] + "/" + values [10] + "/" + values[11];

					well.GetComponent<DisplayInfo> ().inFormation = info1+info2+info3+info4;
					box.GetComponent<DisplayInfo> ().inFormation = info1+info2+info3+info4;
					marker.GetComponent<SpriteRenderer>().color = Color.green;

					wells.Add(well);
					markers.Add(marker);
					depths.Add(depth);
					waters.Add(water);
					boxs.Add(box);
					lsds.Add(lsd);
					sts.Add(thickness);
					deps.Add(well_depth);
					les.Add(land_el);
				}
			}
        }

		//UpdateColors();
    }

	public void UpdateColors()
	{
		float a,b,x;
		for(int i=0; i<wells.Count; i++)
        {
			a = lsds[i];
			b = lsds[i]+sts[i];
			x = les[i]-deps[i];
            if(x < a && b < x)
			{
				markers[i].GetComponent<SpriteRenderer>().color = Color.green;
				//depths[i].GetComponent
			}
			else
			{
				markers[i].GetComponent<SpriteRenderer>().color = Color.red;
			}
        }
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}