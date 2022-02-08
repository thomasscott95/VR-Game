using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gems : MonoBehaviour
{
    public float rotationSpeed = 100.0f;
   
    private bool pickUpAllowed;
    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(new Vector3(0, rotationSpeed * Time.deltaTime, 0));
            
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            col.gameObject.SendMessage("Pickup");
            Destroy(gameObject);
            Debug.Log("Gem picked up");
        }
    }

}

