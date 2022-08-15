using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
   public void Press()
    {
        SceneManager.LoadScene(1);
    }
    
    public void gotoMenu(){
        SceneManager.LoadScene(0);
    }

    public void gotoMenuRoshan(){
        SceneManager.LoadScene(2);
    }

    public void gotoBearDemo(){
        SceneManager.LoadScene(4);
    }

    public void gotoArView(){
        SceneManager.LoadScene(3);
    }

}
