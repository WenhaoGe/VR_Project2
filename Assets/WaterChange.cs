using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterChange : MonoBehaviour {

    public GameObject water_cube;
    // create two particle systems and an audio
    public ParticleSystem rain, rain1;
    public AudioSource s;

    // to-do-list:
    // 1.Read data from a csv file called "precipitation_data"
    // 2.read the data in each line into an array and read each value in the array into new array
    // 3.calculate the average precipitation data for the Spring
    // 4.read data from a csv file called "raster_to_point",then set the longitude, latitude and thickness
    // 5.Instantiate prefab called "water_cube", created the water layer
    // 6.set the average precipitation data to be the water layer thickness 
    public void SetSpring()
    {
        TextAsset txtAsset = (TextAsset)Resources.Load("precipitation_data", typeof(TextAsset));
        string[] lines = txtAsset.text.Split(new char[] { '\n' });
        string[] values = lines[4].Split(',');
        
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
        float average_Spring = (numVal1 + numVal11 + numVal12) / 3;
       

        TextAsset txtAsset1 = (TextAsset)Resources.Load("raster_to_point", typeof(TextAsset));
        string[] newlines = txtAsset1.text.Split('\n');
        //Debug.Log(lines.Length);
        for (int index = 1; index < newlines.Length - 1; index++)
        {
            string[] newvalues = newlines[index].Split(',');
            float longitude = float.Parse(newvalues[2]);
            float latitude = float.Parse(newvalues[3]);
            float thickness = float.Parse(newvalues[1]);

            if (longitude >= -102.0156f && longitude <= -101.74713)
            {
                if (latitude >= 33.47297 && latitude <= 33.69849)
                {
                    float xPos = (longitude - -102.0156f) * 1862.28756f;
                    float zPos = (latitude - 33.47297f) * 2217.098262f;
                    var point = Instantiate(water_cube, new Vector3(xPos, -200f, zPos), Quaternion.identity);
                    point.transform.localScale = new Vector3(12.0f, average_Spring, 12.0f);

                    point.name = values[0];
                }
            }
        }

    }

    // to-do-list:
    // 1.Read data from a csv file called "precipitation_data"
    // 2.read the data in each line into an array and read each value in the array into new array
    // 3.calculate the average precipitation data for the Summer
    // 4.read data from a csv file called "raster_to_point",then set the longitude, latitude and thickness
    // 5.Instantiate prefab called "water_cube", created the water layer
    // 6.set the average precipitation data to be the water layer thickness 
    public void SetSummer()
    {
        TextAsset txtAsset = (TextAsset)Resources.Load("precipitation_data", typeof(TextAsset));
        string[] lines = txtAsset.text.Split(new char[] { '\n' });
        string[] values = lines[4].Split(',');

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
       
         float average_Summer = (numVal2 + numVal3 + numVal4) / 3;
       
        TextAsset txtAsset1 = (TextAsset)Resources.Load("raster_to_point", typeof(TextAsset));
        string[] newlines = txtAsset1.text.Split('\n');
        //Debug.Log(lines.Length);
        for (int index = 1; index < newlines.Length - 1; index++)
        {
            string[] newvalues = newlines[index].Split(',');
            float longitude = float.Parse(newvalues[2]);
            float latitude = float.Parse(newvalues[3]);
            float thickness = float.Parse(newvalues[1]);

            if (longitude >= -102.0156f && longitude <= -101.74713)
            {
                if (latitude >= 33.47297 && latitude <= 33.69849)
                {
                    float xPos = (longitude - -102.0156f) * 1862.28756f;
                    float zPos = (latitude - 33.47297f) * 2217.098262f;
                    var point = Instantiate(water_cube, new Vector3(xPos, -200f, zPos), Quaternion.identity);
                    point.transform.localScale = new Vector3(12.0f, average_Summer, 12.0f);


                    point.name = values[0];
                }
            }
        }
    }

    // to-do-list:
    // 1.Read data from a csv file called "precipitation_data"
    // 2.read the data in each line into an array and read each value in the array into new array
    // 3.calculate the average precipitation data for the Fall
    // 4.read data from a csv file called "raster_to_point",then set the longitude, latitude and thickness
    // 5.Instantiate prefab called "water_cube", created the water layer
    // 6.set the average precipitation data to be the water layer thickness 
    public void SetFall()
    {
        TextAsset txtAsset = (TextAsset)Resources.Load("precipitation_data", typeof(TextAsset));
        string[] lines = txtAsset.text.Split(new char[] { '\n' });
        string[] values = lines[4].Split(',');

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
       
        float average_Fall = (numVal5 + numVal6 + numVal7) / 3;
        
        TextAsset txtAsset1 = (TextAsset)Resources.Load("raster_to_point", typeof(TextAsset));
        string[] newlines = txtAsset1.text.Split('\n');
        //Debug.Log(lines.Length);
        for (int index = 1; index < newlines.Length - 1; index++)
        {
            string[] newvalues = newlines[index].Split(',');
            float longitude = float.Parse(newvalues[2]);
            float latitude = float.Parse(newvalues[3]);
            float thickness = float.Parse(newvalues[1]);

            if (longitude >= -102.0156f && longitude <= -101.74713)
            {
                if (latitude >= 33.47297 && latitude <= 33.69849)
                {
                    float xPos = (longitude - -102.0156f) * 1862.28756f;
                    float zPos = (latitude - 33.47297f) * 2217.098262f;
                    var point = Instantiate(water_cube, new Vector3(xPos, -200f, zPos), Quaternion.identity);
                    point.transform.localScale = new Vector3(12.0f, average_Fall, 12.0f);


                    point.name = values[0];
                }
            }
        }
    }

    // to-do-list:
    // 1.Read data from a csv file called "precipitation_data"
    // 2.read the data in each line into an array and read each value in the array into new array
    // 3.calculate the average precipitation data for the Winter
    // 4.read data from a csv file called "raster_to_point",then set the longitude, latitude and thickness
    // 5.Instantiate prefab called "water_cube", created the water layer
    // 6.set the average precipitation data to be the water layer thickness 

    public void SetWinter()
    {
        TextAsset txtAsset = (TextAsset)Resources.Load("precipitation_data", typeof(TextAsset));
        string[] lines = txtAsset.text.Split(new char[] { '\n' });
        string[] values = lines[4].Split(',');

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
        
        float average_Winter = (numVal8 + numVal9 + numVal10) / 3;

        TextAsset txtAsset1 = (TextAsset)Resources.Load("raster_to_point", typeof(TextAsset));
        string[] newlines = txtAsset1.text.Split('\n');
        //Debug.Log(lines.Length);
        for (int index = 1; index < newlines.Length - 1; index++)
        {
            string[] newvalues = newlines[index].Split(',');
            float longitude = float.Parse(newvalues[2]);
            float latitude = float.Parse(newvalues[3]);
            float thickness = float.Parse(newvalues[1]);

            if (longitude >= -102.0156f && longitude <= -101.74713)
            {
                if (latitude >= 33.47297 && latitude <= 33.69849)
                {
                    float xPos = (longitude - -102.0156f) * 1862.28756f;
                    float zPos = (latitude - 33.47297f) * 2217.098262f;
                    var point = Instantiate(water_cube, new Vector3(xPos, -200f, zPos), Quaternion.identity);
                    point.transform.localScale = new Vector3(12.0f, average_Winter, 12.0f);


                    point.name = values[0];
                }
            }
        }
    }


    // Use this for initialization
    void Start() {
    }

};