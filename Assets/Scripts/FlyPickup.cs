using UnityEngine;
using System.Collections;

public class FlyPickup : MonoBehaviour {

    [SerializeField]
    private GameObject pickupPrefab;
    void OnTriggerEnter(Collider other) {
        if ( other.gameObject.CompareTag("Player")) {
            
            Object.Instantiate(pickupPrefab, this.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
            FlySpawner.totalFlies--;
            ScoreCounter.addScore(1);
        }   
    }
}
