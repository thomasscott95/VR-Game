using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

    public GameObject player;

    public void TeleportPlayerPosisiton() {
        player.transform.position = new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z);
        Debug.Log("Posisition Moved"); 
    }
}
