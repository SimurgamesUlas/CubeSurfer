using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovementController : MonoBehaviour
{
    [SerializeField] private HeroInputController heroInputController;
    [SerializeField] private float forwardMovementSpeed;
    [SerializeField] private float horizontalValueMovementSpeed;
    [SerializeField] private float horizantalLimitValue;
    
    private float newPositionX;

    void FixedUpdate()
    {
        SetHeroForwardMovement();
        setHeroHorizontalMovement();
    }

    private void SetHeroForwardMovement(){
        transform.Translate(Vector3.down * forwardMovementSpeed * Time.fixedDeltaTime);
    }

    private void setHeroHorizontalMovement(){
        newPositionX = transform.position.x + heroInputController.HorizantalValue * horizontalValueMovementSpeed * Time.fixedDeltaTime;
        newPositionX = Mathf.Clamp(newPositionX, -horizantalLimitValue,horizantalLimitValue);
        transform.position = new Vector3(newPositionX,transform.position.y,transform.position.z);
    }
}
