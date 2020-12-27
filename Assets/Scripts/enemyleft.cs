using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyleft : MonoBehaviour
{
    
    public GameObject enemy;
    
    void Start(){

      

    }
    
    
    void OnTriggerEnter2D(Collider2D other){

        if(other.CompareTag("ground") || other.CompareTag("enemy")){
            
            enemymove script = enemy.GetComponent<enemymove>();
            script.direction = 1;
           
        
        }

    }
   

}
