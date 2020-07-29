﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonFiring : MonoBehaviour
{
	public Rigidbody2D laser;
	AudioSource audioSource;
	public bool isVertical;
	public float firingRate;
	private float firingRateFixed;

	void Start()
	{
		firingRateFixed = firingRate;
		audioSource = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update()
	{
		firingRate -= Time.deltaTime;

		if (firingRate <= 0)
		{
			firingRate = firingRateFixed;
			audioSource.Play();
			if (isVertical)
			{
				VerticalFiring();
			}
			else
			{
				HorizontalFiring();
			}

		}
	}

	void VerticalFiring()
	{
		Instantiate(laser, gameObject.transform.position, Quaternion.Euler(new Vector3(0, 0, 90)));
	}
	void HorizontalFiring()
	{
		Instantiate(laser, gameObject.transform.position, Quaternion.Euler(new Vector3(0, 0, 90)));
	}
}
