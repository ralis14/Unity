using UnityEngine;
using System.Collections;

public class ParticleDestruction : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, 5f);
	}
	
}
