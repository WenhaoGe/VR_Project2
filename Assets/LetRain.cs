using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LetRain : MonoBehaviour {

    public ParticleSystem rain,rain1;
    public AudioSource s;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Activate()
    {
        rain.Play();
        rain1.Play();
        s.Play();
    }
}
