using UnityEngine;

public class G2PipeController : MonoBehaviour
{
    public float speed = 10f;
    public float deadZone = -20f; 
    Vector3 initPosition;
    private G2GameManager gameManager;

    void Start()
    {
        initPosition = transform.position;
        gameManager = FindFirstObjectByType<G2GameManager>();
    }

    void Update()
    {
        if (!gameManager.IsGameStarted()) return;
        
        transform.position += new Vector3(speed * Time.deltaTime, 0f);

        if(transform.position.x < deadZone)
        {            
            Destroy(gameObject);
        }
    }
}

