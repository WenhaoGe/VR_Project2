using System.Collections;
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
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            cube.name = values[0];
            float longitude = float.Parse(values[2]);
            float latitude = float.Parse(values[3]);
            float xPos = (-101.527984f - longitude)*6000000/650;
            float zPos = (33.850869f - latitude) * 6000000 / 540;
            cube.transform.position = new Vector3(xPos, 150f, zPos);
            cube.AddComponent<DisplayInfo>();
            cube.GetComponent<DisplayInfo>().inFormation = "X: "+ values[1]+ " Y: "+ values[2]+ " Z: "+ values[3];
        }
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
