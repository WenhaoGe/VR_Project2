using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterChange : MonoBehaviour {

    
    // Use this for initialization
    void Start () {
    
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void ReadFile()
    {
        TextAsset txtAsset = (TextAsset)Resources.Load("precipitation_data", typeof(TextAsset));
        string[] lines = txtAsset.text.Split(new char[] { '\n' });
        


        string[] values = lines[1].Split(',');
        //print(values[1]);
        float numVal1, numVal2, numVal3, numVal4, numVal5, numVal6, numVal7, numVal8, numVal9, numVal10, numVal11, numVal12;
        float.TryParse(values[1],out numVal1);
        float.TryParse(values[2],out numVal2);
        float.TryParse(values[3],out numVal3);
        float.TryParse(values[4],out numVal4);
        float.TryParse(values[5],out numVal5);
        float.TryParse(values[6],out numVal6);
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

        print(average_Spring);
        print(average_Summer);
        print(average_Fall);
        print(average_Winter);
    }
}
;