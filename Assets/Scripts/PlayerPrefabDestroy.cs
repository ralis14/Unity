using UnityEngine;
using System.Collections;

public class PlayerPrefabDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, 4f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
