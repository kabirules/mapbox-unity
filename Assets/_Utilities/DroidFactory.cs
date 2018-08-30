﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class DroidFactory : Singleton<DroidFactory> {

	[SerializeField] private Droid[] availableDroids;
	[SerializeField] private Player player;
	[SerializeField] private float waitTime = 180.0f;
	[SerializeField] private int startingDroids = 5;
	[SerializeField] private float minRange = 5.0f;
	[SerializeField] private float maxRange = 50.0f;

	private void Awake() {
        Assert.IsNotNull(availableDroids);
		Assert.IsNotNull(player);
	}

	// Use this for initialization
	void Start () {
		
	}

	private void InstantiateDroid() {
		int index = Random.Range(0, availableDroids.Length);
		float x = player.transform.position.x + GenerateRange();
		float y = player.transform.position.y + GenerateRange();
		float z = player.transform.position.z + GenerateRange();
		Instantiate(availableDroids[index], new Vector3(z, y, z), Quaternion.identity);
	}

	private float GenerateRange() {
		float randomNum = Random.Range(minRange, maxRange);
		bool isPositive = Random.Range(0, 10) < 5;
		return randomNum * (isPositive ? 1 : -1);
	}



}
