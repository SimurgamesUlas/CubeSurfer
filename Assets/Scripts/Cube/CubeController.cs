using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    [SerializeField] private HeroStackControlelr heroStackControlelr;
    private Vector3 direction = Vector3.back;
    private bool isStack = false;
    private RaycastHit hit;
    void Start()
    {
        heroStackControlelr = GameObject.FindObjectOfType<HeroStackControlelr>();
    }
    void FixedUpdate()
    {
        setCubeRaycast();

    }
    private void  setCubeRaycast(){
        if(Physics.Raycast(transform.position, direction,out hit ,1f)){
            if(!isStack){
                isStack = true;
                heroStackControlelr.IncreaseBlockStack(gameObject);
                SetDirection();
            }
            if(hit.transform.name == "ObstacleCube"){
                heroStackControlelr.DecraseBlock(gameObject);
            }
        }
    }
    private void SetDirection(){
        direction = Vector3.forward;
    }
}
