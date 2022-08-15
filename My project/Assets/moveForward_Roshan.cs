using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveForward_Roshan : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator animator;
    public bool walkForward;

     private float timer = 0;
    private float timerMax = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(walkForward){
            animator.SetBool("WalkForward", true);
            transform.Translate(Vector3.forward * Time.deltaTime * 1);

            if(!Waited(6)) return;
            SceneManager.LoadScene(2);


        }
    }
    public void walk(){
        walkForward = true;
    }

     private bool Waited(float seconds)
     {
         timerMax = seconds;
 
         timer += Time.deltaTime;
 
         if (timer >= timerMax)
         {
             return true; //max reached - waited x - seconds
         }
 
         return false;
     }
}
