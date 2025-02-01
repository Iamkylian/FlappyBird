using UnityEngine;

public class G2Player : MonoBehaviour
{

    Rigidbody2D Rigidbody;
    bool isJumping = false;
    public float jumpForce = 100f;
    public float gravity = 3.5f;
    private G2GameManager gameManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
        Rigidbody.gravityScale = gravity;
        gameManager = FindFirstObjectByType<G2GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -5.5f || !gameManager.IsGameStarted() || gameManager.restartButton.gameObject.activeSelf) 
        {
            return;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Jump");
            isJumping = true;
        }
    }

    private void FixedUpdate()
    {
        if(isJumping)
        {
            Debug.Log("Jumping");
            Rigidbody.linearVelocity = new Vector2(0.0f, 0.0f);
            Rigidbody.AddForce(new Vector2(0f, jumpForce));
            isJumping = false;
        }
    }
}
