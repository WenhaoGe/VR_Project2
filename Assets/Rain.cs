using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rain : MonoBehaviour {
    public ParticleSystem rain, rain1;
    public AudioSource s;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StopRain()
    {
        rain.Stop();
        rain1.Stop();
        s.Stop();

    }
}
