using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyside : MonoBehaviour
{

    public GameObject enemy;
    public GameObject dedenemy;
    public GameObject Wincheck;
 
        void OnTriggerEnter2D(Collider2D other){

        if(other.CompareTag("Player")){
            
            wincheck script = Wincheck.GetComponent<wincheck>();
            script.ded1 = 1; 
            enemydefeatimation script2 = dedenemy.GetComponent<enemydefeatimation>();
            script2.isded = 1; 
            
           
        
        }

    }
    

}
