using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemytop : MonoBehaviour
{
     public GameObject dedguy;

    void OnTriggerEnter2D(Collider2D other){

    if(other.CompareTag("Player")){

        
        dedanimation script = dedguy.GetComponent<dedanimation>();
        script.isded = 1;
        
        
        
    }

    }
    

    
    
    



}
