using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class restartscript : MonoBehaviour
{
    public Image white;
    public Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

        void OnTriggerEnter2D(Collider2D other){

        if(other.CompareTag("dedguy")){
            
           StartCoroutine(Fading());
            //SceneManager.LoadScene("level 3");
           //SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        
        }

    }
    
    IEnumerator Fading(){
    anim.SetBool("fade",true);
    yield return new WaitUntil(()=>white.color.a==1);
    SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
    }

}
