using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class wincheck : MonoBehaviour
{
    public float ded1 = 0;
    public float ded2 = 0;
    public float ded3 = 0;
    public Image white;
    public Animator anim;
    public float timer = 0;

    // Update is called once per frame
    void Update()
    {
        if(ded1 == 1 && ded2 == 1 && ded3 == 1){
          timer += 1;  
        }   
        if(timer == 1){  
            StartCoroutine(Fading());
        }
    }

    IEnumerator Fading(){
    anim.SetBool("fade",true);
    yield return new WaitUntil(()=>white.color.a==1);
    SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex+1);
    }
}
