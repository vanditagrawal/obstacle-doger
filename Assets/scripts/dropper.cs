using UnityEngine;

public class dropper : MonoBehaviour
{
    [SerializeField] float timetowait = 10f;
    MeshRenderer myMeshRenderer;
    Rigidbody myRigidbody;
   void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidbody = GetComponent<Rigidbody>();

        myMeshRenderer.enabled = false;
        myRigidbody.useGravity = false;
    }
    void Update()
    {
        if (Time.time > timetowait)
        
    {  
        myMeshRenderer.enabled = true;
        myRigidbody.useGravity = true;
    }
           
    }
}
