using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class activarmano : MonoBehaviour
{
    public GameObject tinta;
    public GameObject grab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player"))
        {
           grab.SetActive(true);
            if(tinta != null && grab && Input.GetKeyDown(KeyCode.E))
                {
                tinta.SetActive(true);
            }
        }
    }
}
