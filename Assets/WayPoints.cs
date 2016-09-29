﻿using UnityEngine;


public class WayPoints : MonoBehaviour {

	public static Transform[] points;

	void Awake () {
		Debug.Log (transform.childCount);
		points = new Transform[transform.childCount];
		for (int i = 0; i < points.Length; i++) {
			points[i] = transform.GetChild(i);
		}
	}
}
