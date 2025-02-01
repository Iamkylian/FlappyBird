using UnityEngine;

public class G2Floor : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        G2Player _player = collision.gameObject.GetComponent<G2Player>();
        if(_player != null)
        {
            FindFirstObjectByType<G2GameManager>().KillPlayer();
        }
    }
}
=