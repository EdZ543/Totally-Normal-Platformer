using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class flagkill : MonoBehaviour
{

    public GameObject dedguy;
    Vector3 pos;

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        gameObject.transform.position = pos;

        if(pos.x > 9){
            dedanimation script = dedguy.GetComponent<dedanimation>();
            script.isded = 1;
        }
          

        
    }


    
}
