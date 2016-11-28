using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour {

    [SerializeField]
    private Text gameStateText;

    private bool gameStarted = false;

    [SerializeField]
    private GameObject player;
    [SerializeField]
    private BirdMovement birdMovement;
    [SerializeField]
    private FollowCamera followCamera;
    private float restartDelay = 3f;
    private float restartTimer;
    private PlayerMovement playerMovement;
    private PlayerHealth playerHealth;
    //private BirdMovement birdMovement;

	// Use this for initialization
	void Start () {
        Cursor.visible = false;
        playerMovement = player.GetComponent<PlayerMovement>();
        playerHealth = player.GetComponent<PlayerHealth>();
        //birdMovement = GetComponent<BirdMovement>();

        playerMovement.enabled = false;
        birdMovement.enabled = false;
        followCamera.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        //if (player == null) { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); }
        if (!gameStarted && Input.GetKeyUp(KeyCode.Space)) { startGame(); }
        else if(PlayerHealth.playerAlive == false){
            endGame();
            restartTimer = restartTimer + Time.deltaTime;
            if (restartTimer >= restartDelay) {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
              //  SceneManager.LoadScene("set_up");
            }
        }
	
	}
    private void startGame() {
        gameStarted = true;
        gameStateText.color = Color.clear;
        playerMovement.enabled = true;
        birdMovement.enabled = true;
        followCamera.enabled = true;
    }

    private void endGame() {
        gameStarted = false;
        gameStateText.text = " Game Over ";
        gameStateText.color = Color.white;
        player.SetActive(false);
    }
}
