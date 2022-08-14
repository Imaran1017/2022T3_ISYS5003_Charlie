using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using TMPro;

public class rotateAround_Roshan : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public bool rotate;
    public TextMeshProUGUI cameraText;

    void Start()
    {
        
    }

    public void ToggleRotate(){
        rotate = !rotate;
    }

    // Update is called once per frame
    void Update()
    {
        if(rotate){
            //transform.RotateAround(target.position, target.right, Time.deltaTime * speed);
            cameraText.text = "Stop Rotating";
            transform.RotateAround (target.position, Vector3.up, 30 * Time.deltaTime);
        }else{
            cameraText.text = "Start Rotating";
        }

    }
}
