//moves the paddle, pretty self explanatory
using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed = 10f;
    public GameObject Paddle;
    public KeyCode upKey;
    public KeyCode downKey;

    void Start()
    {
        
    }

    void Update()
    {
         if (Input.GetKey(upKey))
        {
            if(Paddle.transform.position.y < 5)
            Paddle.transform.position += Vector3.up * moveSpeed * Time.deltaTime; 
        }
        if (Input.GetKey(downKey))
        {
            if(Paddle.transform.position.y > -5)
            Paddle.transform.position += Vector3.down * moveSpeed * Time.deltaTime; 
        }
    }
}
