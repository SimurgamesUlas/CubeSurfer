using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroStackControlelr : MonoBehaviour
{
   
    public List<GameObject> blocklist = new List<GameObject>();
    private GameObject lastBlockObject;
    void Start()
    {
        UpdateLastBlockObject();
    }

    public void IncreaseBlockStack(GameObject _gameObjcet){
        transform.position = new Vector3(transform.position.x,transform.position.y + 2f,transform.position.z);
        _gameObjcet.transform.position = new Vector3(lastBlockObject.transform.position.x,lastBlockObject.transform.position.y -2f,lastBlockObject.transform.position.z);
        _gameObjcet.transform.SetParent(transform);
        blocklist.Add(_gameObjcet);
        UpdateLastBlockObject();
    }
    public void DecraseBlock(GameObject _gameObject){
        _gameObject.transform.parent = null;
        blocklist.Remove(_gameObject);
        UpdateLastBlockObject();
    }
    private void UpdateLastBlockObject(){
        lastBlockObject = blocklist[blocklist.Count -1];
    }
}
