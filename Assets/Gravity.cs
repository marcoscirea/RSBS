using UnityEngine;
using System.Collections;

public class Gravity : MonoBehaviour
{

	GameObject[] ships;
	float g;

	// Use this for initialization
	void Start()
	{
		ships = GameObject.FindGameObjectsWithTag("Ship");
	}
    
	// Update is called once per frame
	void FixedUpdate()
	{
		foreach (GameObject s in ships) {
			float f = g * (this.rigidbody.mass * s.rigidbody.mass) / Mathf.Pow(Vector3.Distance(this.transform.position, s.transform.position), 2f);
			s.rigidbody.AddForce( Vector3.Normalize(s.transform.position - this.transform.position) * f);
		}
	}
}
