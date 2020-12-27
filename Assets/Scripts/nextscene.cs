using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class nextscene : MonoBehaviour
{
    public Image white;
    public Animator anim;
    public GameObject player;
    
    void OnTriggerEnter2D(Collider2D other){

        if(other.CompareTag("Player")){
            
            StartCoroutine(Fading());
            Destroy(player);
        
        }

    }

    IEnumerator Fading(){
    anim.SetBool("fade",true);
    yield return new WaitUntil(()=>white.color.a==1);
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    
    
}
