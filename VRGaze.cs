using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRGaze : MonoBehaviour {
    public Image gazeImage;

    public float totalTime = 2;
    bool gvrStatus;
    float gvrTimer;

    public int rayCast = 10;
    private RaycastHit beenHit;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (gvrStatus) {
            gvrTimer += Time.deltaTime;
            gazeImage.fillAmount = gvrTimer / totalTime;
        }

        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0.5f));
        if (Physics.Raycast(ray, out beenHit, rayCast)){
            if (gazeImage.fillAmount == 1 && beenHit.transform.CompareTag("Teleport")) {
                beenHit.transform.gameObject.GetComponent<Teleport>().TeleportPlayerPosisiton();
            }
        }
	}

    public void GVROn() {
        gvrStatus = true;
        gazeImage.enabled = true;
        Debug.Log("Gaze Running");
    }

    public void GVROff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        gazeImage.fillAmount = 0;
        gazeImage.enabled = false;
        Debug.Log("Gaze Not Running");

    }
}
