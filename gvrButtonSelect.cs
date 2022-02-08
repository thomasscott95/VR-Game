using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class gvrButtonSelect : MonoBehaviour {

    public Image gazeImage;
    public UnityEvent gvrClick;
    public float totalTime = 2;
    bool gvrStatus;
    public float gvrTimer;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (gvrStatus) {
            gvrTimer += Time.deltaTime;
            gazeImage.fillAmount = gvrTimer / totalTime;
            Debug.Log("Update Runs");
        }

        if (gvrTimer > totalTime) {
            gvrClick.Invoke();
            Debug.Log("Click Worked");
        }
	}

    public void GVROn() {
        gvrStatus = true;
        Debug.Log("Viewing Button");
    }

    public void GVROff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        gazeImage.fillAmount = 0;
        Debug.Log("Not Viewing Button anymore");
    }
}
