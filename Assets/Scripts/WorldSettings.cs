using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldSettings : MonoBehaviour
{
	public Terrain terrain;
	public Material orig_mat;
	public Material other_mat;
	public ParticleSystem rain;
    public AudioSource rain_sound;
	private Material current_mat;

	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public void TriggerTerrainView ()
	{
		if(terrain.materialTemplate == orig_mat)
		{
			terrain.materialTemplate = other_mat;
		}
		else
		{
			terrain.materialTemplate = orig_mat;
		}
	}

	public void StartRain ()
	{
		rain.Play();
        rain_sound.Play();
	}

	public void StopRain ()
	{
		rain.Stop();
        rain_sound.Stop();
	}
}
