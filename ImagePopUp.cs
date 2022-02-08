using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImagePopUp : MonoBehaviour {
    [SerializeField]private Image imageView;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
            imageView.enabled = true;
            Debug.Log("Image Appear");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            imageView.enabled = false;
            Debug.Log("Image Gone");

        }
    }


}
