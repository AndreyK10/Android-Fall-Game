using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField] private float moveSpeed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //if (Input.GetKey(KeyCode.A))
        //{
        //    MoveLeft();
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    MoveRight();
        //}

        if (!GameplayController.isPaused)
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.touches[0];
                if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
                {
                    if (touch.position.x > Screen.width / 2)
                    {
                        MoveRight();
                    }
                    else if (touch.position.x < Screen.width / 2)
                    {
                        MoveLeft();
                    }
                }
            }
        }
    }

    public void MoveRight()
    {        
        Move(1);
    }

    public void MoveLeft()
    {
        Move(-1);        
    }

    private void Move(int direction)
    {
        rb.velocity = new Vector2(moveSpeed * direction, rb.velocity.y);
    }
}
