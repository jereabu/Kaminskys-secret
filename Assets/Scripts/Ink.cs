using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ink : MonoBehaviour
{
    public Text Grab;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerStay(Collider other) {
        if (other == null || !other.CompareTag("Player")){
            Grab.enabled = true;
        } 
    }
}
