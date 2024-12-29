using UnityEngine;

public class BallMove : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float startDelay = 2f;
    public Rigidbody2D rb;  
    private Logic logic;
    public TrailRenderer trail;
    
    void Start()
    {

        logic = GetComponent<Logic>();
        rb.position = new Vector2(0, 0);
       Invoke("InitialVelocity", startDelay);
    }
    void InitialVelocity()
    {
         if(trail.time == 0)
        {
            trail.time = 0.2f;
        }
        Vector2 randomDirection;
        do
        {
            randomDirection = Random.insideUnitCircle.normalized;
        } while (Mathf.Abs(randomDirection.x) < 0.1f);
        
        rb.linearVelocity = randomDirection * moveSpeed;
    }


    void Update()
    {
        if(rb.position.y > 6.24)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, -rb.linearVelocity.y);
            rb.position = new Vector2(rb.position.x, 6.24f);
        }
        if(rb.position.y < -6.24)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, -rb.linearVelocity.y);
            rb.position = new Vector2(rb.position.x, -6.24f);
        }
        if(rb.position.x > 13 || rb.position.x < -13)
        {
            trail.time = 0;
            rb.linearVelocity = new Vector2(0,0);
            Start();
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("TriggerL"))
        {
            logic.addscoreR();
        }
        if (other.CompareTag("TriggerR"))
        {
            logic.addscoreL();
        }
    
   }
}
