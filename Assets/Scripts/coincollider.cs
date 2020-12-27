using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coincollider : MonoBehaviour
{
    public GameObject dedguy;
    
    void OnTriggerEnter2D(Collider2D other){

        if(other.CompareTag("Player")){
            
            //Destroy(player);
            dedanimation script = dedguy.GetComponent<dedanimation>();
            script.isded = 1;
           
        
        }

    }
}
