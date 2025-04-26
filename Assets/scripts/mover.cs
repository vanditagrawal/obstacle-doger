using UnityEngine;
public class mover : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]float MoveSpeed = 0f;  
    void Start()
    {
       PrintInstructions();
      
    }

    // Update is called once per frame
    void Update()
    {
         MovePlayer();
        // float xValue = Input.GetAxis("Horizontal") * Time.deltaTime* MoveSpeed;
        // float yValue = 0f;
        // float zValue = Input.GetAxis("Vertical")* Time.deltaTime * MoveSpeed;
        // transform.Translate(xValue , yValue , zValue);
    }
    
    void PrintInstructions()
    {
    Debug.Log("Welcome to the game!");
    Debug.Log("Move using arrow keys WSAD!");
    Debug.Log("Do not bump into obstacles!");
    
    }

    void MovePlayer()

    {  
    float xValue = Input.GetAxis("Horizontal") * Time.deltaTime* MoveSpeed;
    float yValue = 0f;
    float zValue = Input.GetAxis("Vertical")* Time.deltaTime * MoveSpeed;
    transform.Translate(xValue , yValue , zValue);
    }
}
