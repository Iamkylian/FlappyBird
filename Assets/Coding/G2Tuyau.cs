using UnityEngine;

public class G2Tuyau : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision) {
        G2Player _player = collision.gameObject.GetComponent<G2Player>();
        if (_player != null) {
            _player.gameObject.SetActive(false);
            FindFirstObjectByType<G2GameManager>().KillPlayer();
        }
    }
}
