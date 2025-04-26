using UnityEngine;

public class scorer : MonoBehaviour
{
    int Hit = 0;
    
    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag != "Hit")
            {
            // Hit = Hit + 1;
            Hit++;
            Debug.Log("you have bumped into the wall this many times : " + Hit );
            }
    }
}
