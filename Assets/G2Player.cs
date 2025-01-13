using UnityEngine;

public class G2Player : MonoBehaviour
{

    Rigidbody2D Rigidbody;
    bool isJumping = false;
    public float jumpForce = 100f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
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
            Rigidbody.AddForce(new Vector2(0f, jumpForce));
            isJumping = false;
        }
    }
}
