using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemydefeat : MonoBehaviour
{
    public float ded = 0;
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        if(ded == 3){
            Destroy(player);
        }
    }
}
