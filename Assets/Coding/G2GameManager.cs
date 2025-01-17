using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class G2GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score;
    public Button restartButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 0f;
        restartButton.onClick.AddListener(() => RestartGame());
        restartButton.gameObject.SetActive(false);
    }

    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space)) {
            Time.timeScale = 1f;
        }

        if(Input.GetKeyDown(KeyCode.R)) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void AddScore() {
        score ++;
        scoreText.text = "Score: " + score;
    }

    public void KillPlayer() {
        OnPlayerDie();
    }

    public void OnPlayerDie() {
        Time.timeScale = 0f;
        scoreText.text = "You best score is: " + score;
        restartButton.gameObject.SetActive(true);
    }
}

