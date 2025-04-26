using UnityEngine;

public class flyatplayer : MonoBehaviour
{
    [SerializeField] float bulletspeed = 5f;
    [SerializeField] Transform player;
    Vector3 playerPosition;
    private void Awake()
    {
        gameObject.SetActive(false); 
    }
    void Start()
    {
        playerPosition = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }
    void MoveToPlayer()
    {
        transform.position = 
        Vector3.MoveTowards(transform.position, playerPosition , Time.deltaTime*bulletspeed);
        
    }
    void DestroyWhenReached()
    {
        if(transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
       
    }
}
