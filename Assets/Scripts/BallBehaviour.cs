using UnityEngine;

public class BallBehaviour : MonoBehaviour
{

    float movementSpeed;
    private Rigidbody2D ballBody;
    

    // Start is called before the first frame update
    void Start()
    {
        ballBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
       


    }

    private void FixedUpdate()
    {
        movementSpeed = Random.Range(-3f, 3f);
        ballBody.velocity = new Vector2(movementSpeed * 2f, movementSpeed - 1f);
    }
}
