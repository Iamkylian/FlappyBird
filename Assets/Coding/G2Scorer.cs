using UnityEngine;

public class G2Scorer : MonoBehaviour
{
    public G2GameManager gameManager;

    private int score;

    private void Start() {
        gameManager = FindFirstObjectByType<G2GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        G2Player _player = collision.gameObject.GetComponent<G2Player>();
        if (_player != null) {
            gameManager.AddScore();
        } else {
            gameManager.KillPlayer();
        }
    }
}
