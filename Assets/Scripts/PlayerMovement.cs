using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    private Animator playerAnimator;
    private float moveHorizontal;
    private float moveVertical;
    private Vector3 movement;
    private float turningSpeed = 20f;
    private Rigidbody playerRigidBody;

    [SerializeField]
    private RandomSoundPlayer playerFootSteps;

	// Use this for initialization
	void Start () {
        //Get component
        playerAnimator = GetComponent<Animator> ();
        playerRigidBody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
        //Get input from keyboard
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");

        movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
	}

    void FixedUpdate() {
        if (movement != Vector3.zero)
        {
            //Create a targer verctor based on movement variable
            Quaternion targetRotation = Quaternion.LookRotation(movement, Vector3.up);
            Quaternion newRotation = Quaternion.Lerp(playerRigidBody.rotation, targetRotation, turningSpeed*Time.deltaTime);

            //apply to player
            playerRigidBody.MoveRotation(newRotation);

            playerAnimator.SetFloat("Speed", 3f);
            playerFootSteps.enabled = true;
        }
        else {
            playerAnimator.SetFloat("Speed", 0f);
            playerFootSteps.enabled = false;
        }
    }
}
