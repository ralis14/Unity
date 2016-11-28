using UnityEngine;
using System.Collections;

public class FlyMovement : MonoBehaviour {
    [SerializeField]
    private Transform center;

    private Vector3 point, axis;
    private float flySpeed;

	// Use this for initialization
	void Start () {
        flySpeed = Random.Range(300f, 700f);
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(center.position, center.up, flySpeed*Time.deltaTime);
	}
}
