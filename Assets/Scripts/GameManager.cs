using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool gameIsPaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
            }

            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    bool gamehasEnded = false;
    public float delay = .5f;
    public GameObject Player;

    public GameObject endGameMenuUI;
    public GameObject levelCompleteMenuUI;

    public void LevelComplete()
	{
        levelCompleteMenuUI.SetActive(true);
	}

    public void LoadNextLevel()
	{
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

    public void EndGame()
    {
        if(gamehasEnded == false)
        {
            gamehasEnded = true;
            Player.GetComponent<PlayerMovement>().enabled = false;
            Invoke("GameOverMenu", delay);
        }
    }

    void GameOverMenu()
    {
        endGameMenuUI.SetActive(true);
    }

    public void PlayAgain()
    {
        endGameMenuUI.SetActive(false);
        Time.timeScale = 1f;

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
