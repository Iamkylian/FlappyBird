using UnityEngine;

public class G2Level : MonoBehaviour
{
    public float speed = 10f;
    public float deadZone = -20f;
    Vector3 initPosition;

    void Start()
    {
        initPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(10f * Time.deltaTime, 0f);

        if(transform.position.x < deadZone)
        {
            transform.position = initPosition;
        }
    }
}
