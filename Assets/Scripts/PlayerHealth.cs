using UnityEngine;
using System.Collections;


public class PlayerHealth : MonoBehaviour
{
    public static bool playerAlive;

    [SerializeField]
    private GameObject pickupPrefab;

    // Use this for initialization
    void Start()
    {
        playerAlive = true;

    }

    void OnTriggerEnter(Collider other) {
      
            if (other.name == "Bird" && playerAlive == true)
            {
                playerAlive = false;
                 //Destroy(this.gameObject);
                Object.Instantiate(pickupPrefab, this.transform.position, Quaternion.identity);
                //Destroy(other.gameObject, 2f);
            }
    }
}
