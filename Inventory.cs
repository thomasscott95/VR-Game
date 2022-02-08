using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{

    public static int charge = 0;
    public AudioClip collectSound;

    // HUD
    public Texture2D[] hudCharge;
    public RawImage chargeHudGUI;


    // Use this for initialization
    void Start()
    {
        charge = 0;
    }

    void Pickup()
    {
        HUDon();
        AudioSource.PlayClipAtPoint(collectSound, transform.position);
        charge++;
        chargeHudGUI.texture = hudCharge[charge];
        Debug.Log("Gem Picked Up");
        Debug.Log("Audio Played");
        Debug.Log("Gem GUI Triggered");
    }

    void HUDon()
    {
        if (!chargeHudGUI.enabled)
        {
            chargeHudGUI.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }



}
