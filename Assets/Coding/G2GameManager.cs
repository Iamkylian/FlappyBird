using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class G2GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score;
    public Button restartButton;
    public AudioSource audioSource;
    public AudioClip startGameSound;
    private bool gameStarted = false;

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
        if(!gameStarted && Input.GetKeyDown(KeyCode.Space) && !restartButton.gameObject.activeSelf) {
            StartGame();
        }

        if(Input.GetKeyDown(KeyCode.R)) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void StartGame()
    {
        gameStarted = true;
        Time.timeScale = 1f;
        PlayStartGameSound();
    }

    private void PlayStartGameSound()
    {
        if (audioSource != null && startGameSound != null)
        {
            audioSource.clip = startGameSound;
            audioSource.Play();
        }
    }

    private void StopGameSound()
    {
        if (audioSource != null)
        {
            audioSource.Stop();
        }
    }

    public void AddScore() {
        score ++;
        scoreText.text = "Score: " + score;
    }

    public void KillPlayer() {
        Debug.Log("KillPlayer");
        gameStarted = false;
        Time.timeScale = 0f;
        scoreText.text = "You best score is: " + score;
        restartButton.gameObject.SetActive(true);
        gameStarted = false;
        StopGameSound();
    }

    public bool IsGameStarted()
    {
        Debug.Log("GameStarted ? : " + gameStarted);
        return gameStarted;
    }
}

