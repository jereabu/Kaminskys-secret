using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public int tinta = 3;
    public int papel = 3; 
    public Text Tinta;
    public Text Papel;  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tinta <= 0){
            Tinta.text = "No ink left" ;
        }
        if(papel <= 0){
            Papel.text= "No paper left";
        }
    }
}
