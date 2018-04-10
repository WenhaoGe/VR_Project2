using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateUGWater : MonoBehaviour {

    // Use this for initialization

	public GameObject water_cube;

    public void ReadFile()
    {
        TextAsset txtAsset = (TextAsset)Resources.Load("precipitation_data", typeof(TextAsset));
        string[] lines = txtAsset.text.Split(new char[] { '\n' });



        string[] values = lines[1].Split(',');
        //print(values[1]);
        float numVal1, numVal2, numVal3, numVal4, numVal5, numVal6, numVal7, numVal8, numVal9, numVal10, numVal11, numVal12;
        float.TryParse(values[1], out numVal1);
        float.TryParse(values[2], out numVal2);
        float.TryParse(values[3], out numVal3);
        float.TryParse(values[4], out numVal4);
        float.TryParse(values[5], out numVal5);
        float.TryParse(values[6], out numVal6);
        float.TryParse(values[7], out numVal7);
        float.TryParse(values[8], out numVal8);
        float.TryParse(values[9], out numVal9);
        float.TryParse(values[10], out numVal10);
        float.TryParse(values[11], out numVal11);
        float.TryParse(values[12], out numVal12);

        // calculate the average precipitation data of four seasons
        double average_Spring = (numVal1 + numVal11 + numVal12) / 3;
        double average_Summer = (numVal2 + numVal3 + numVal4) / 3;
        double average_Fall = (numVal5 + numVal6 + numVal7) / 3;
        double average_Winter = (numVal8 + numVal9 + numVal10) / 3;

        /*  print(average_Spring);
          print(average_Summer);
          print(average_Fall);
          print(average_Winter);*/
    }

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