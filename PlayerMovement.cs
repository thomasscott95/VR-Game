using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Transform vrCamera;
    public float angel;
    public float speed;
    public bool movement;

    private CharacterController getCharaacterController;


	// Use this for initialization
	void Start () {
        getCharaacterController = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        if (vrCamera.eulerAngles.x >= angel && vrCamera.eulerAngles.x < 90.0f)
        {
            movement = true;
        }
        else {
            movement = false;
        }

        if (movement) {
            Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
            getCharaacterController.SimpleMove(forward * speed);
            Debug.Log("Player Moving");
        }
	}
}
