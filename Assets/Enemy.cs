using UnityEngine;

public class Enemy : MonoBehaviour {

	public float speed = 10f;

	private Transform target;

	private int wavePointIndex = 0;

	// Use this for initialization
	void Start () {
		Debug.Log ("Start");
		target = WayPoints.points [0];

	}

	void Update () {

		Vector3 dir = target.position - transform.position; 
		transform.Translate (dir.normalized * speed * Time.deltaTime, Space.World);

		if (Vector3.Distance (transform.position, target.position) <= 0.6f) {
			GetNextWaypoint ();
		}

	}

	void GetNextWaypoint ()
	{
		if (wavePointIndex >= WayPoints.points.Length - 1) {
			Destroy (gameObject);
			return;
		}

		target = WayPoints.points [++wavePointIndex];
	}
}
