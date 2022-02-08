using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pathTwo : MonoBehaviour {

    public GameObject uiText;
    // Use this for initialization
    void Start()
    {
        uiText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            uiText.SetActive(true);
            StartCoroutine("DelayedText");
            Debug.Log("Player Ran Into Box");
        }
    }

    IEnumerator DelayedText()
    {
        yield return new WaitForSeconds(7);
        Destroy(uiText);
        Destroy(gameObject);
        Debug.Log("ran");
    }
}
