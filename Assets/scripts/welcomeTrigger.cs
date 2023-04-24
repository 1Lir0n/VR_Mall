using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class welcomeTrigger : MonoBehaviour
{

    public GameObject welcomeText;
    private bool on_time = true;
    // Start is called before the first frame update
    void Start()
    {
        welcomeText.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && on_time) 
        {
            welcomeText.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        welcomeText.SetActive(false);
        on_time = false;
    }

}
