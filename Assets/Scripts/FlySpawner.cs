using UnityEngine;
using System.Collections;

public class FlySpawner : MonoBehaviour {

    [SerializeField]
    private GameObject flyPrefab;

    [SerializeField]
    private int totalFlyMinimum = 12;

    private float spawnArea = 21f;

    public static int totalFlies;
	// Use this for initialization
	void Start () {
        totalFlies = 0;
	}
	
	// Update is called once per frame
	void Update () {
        while (totalFlies < totalFlyMinimum) {
            float positionX = Random.Range(-spawnArea, spawnArea);
            float positionZ = Random.Range(-spawnArea, spawnArea);
            Vector3 flyPosition = new Vector3(positionX, 2f, positionZ);
            Object.Instantiate(flyPrefab, flyPosition, Quaternion.identity);
            totalFlies++;
        }
	}
}
