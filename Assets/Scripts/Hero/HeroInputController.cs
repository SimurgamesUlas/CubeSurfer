using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroInputController : MonoBehaviour
{
    private float horizontalValue;
    public float HorizantalValue{

        get { return horizontalValue; }
    }
   

    
    void Update()
    {
        handleHeroHorizontalInput();
    }

    private void handleHeroHorizontalInput(){
        if(Input.GetMouseButton(0)){
            horizontalValue = Input.GetAxis("Mouse X");
        }else{
            horizontalValue = 0;
        }
    }
}
