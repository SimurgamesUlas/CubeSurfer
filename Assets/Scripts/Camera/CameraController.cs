using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform heroTransform;
    private UnityEngine.Vector3 offset;
    private UnityEngine.Vector3 newPosition;
    [SerializeField] private float lerpValue;
    void Start()
    {
        offset =  transform.position - heroTransform.position;
    }

    
    void LateUpdate()
    {
        setCameraSmoothFollow();
    }

    private void setCameraSmoothFollow(){
        newPosition = UnityEngine.Vector3.Lerp(transform.position,new UnityEngine.Vector3(0f,heroTransform.position.y,heroTransform.position.z) + offset, lerpValue * Time.deltaTime);
        transform.position = newPosition;
    }
}
