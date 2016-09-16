using UnityEngine;
using System.Collections;

public class SunCycle : MonoBehaviour {
    [Tooltip("Number of minutes per second that pass, try 60")]
    public float minutesPerSecond;
    private Quaternion initialRotation;
	void Start () {
        initialRotation = this.transform.rotation;
	}
	

	void Update () {
        float angleThisFrame = Time.deltaTime / 360 * minutesPerSecond;
        transform.RotateAround(transform.position,Vector3.forward,angleThisFrame);
	}
}
