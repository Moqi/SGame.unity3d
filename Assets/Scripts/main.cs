using UnityEngine;
using System.Collections;

public class main : MonoBehaviour {
	public float angleSpeed = 1.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.up, angleSpeed*Time.deltaTime);
	}
}
