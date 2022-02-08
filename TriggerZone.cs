using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerZone : MonoBehaviour
{


    public AudioClip lockedSound;
    public Text textHints;

    // Use this for initialization
    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (Inventory.charge == 4)

            {
                transform.Find("door").SendMessage("DoorCheck");
                Debug.Log("we have all the gems");

                if (GameObject.Find("gemGUI"))
                {
                    Destroy(GameObject.Find("gemGUI"));
                }
            }
            else if (Inventory.charge > 0 && Inventory.charge < 4)
            {
                textHints.SendMessage("ShowHint", "This door won't budge... need to offer gems to the gods to get in - maybe more gems will help");
                transform.Find("door").GetComponent<AudioSource>().PlayOneShot(lockedSound);
            }

            else
            {
                transform.Find("door").GetComponent<AudioSource>().PlayOneShot(lockedSound);
                col.gameObject.SendMessage("HUDon");
                textHints.SendMessage("ShowHint", "This door is locked... maybe we need to offer something to the gods to gain access...");
            }

        }
    }


}
