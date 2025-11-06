using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    enum mode {mainMenu, quit};

    public GameObject pauseMenuUI;
    public GameObject confirmUI;
    mode selectedMode;

    void Start()
    {
        pauseMenuUI.SetActive(false);
        confirmUI.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
            {
                pauseMenuUI.SetActive(true);

                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            else
            {
                Time.timeScale = 1;
                pauseMenuUI.SetActive(false);

                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }
    }

    public void ContinueGamePressed()
    {
        Time.timeScale = 1;
        pauseMenuUI.SetActive(false);
    }

    public void BackMainMenuPressed()
    {
        selectedMode = mode.mainMenu;

        pauseMenuUI.SetActive(false);
        confirmUI.SetActive(true);
    }

    public void QuitGamePressed()
    {
        selectedMode = mode.quit;

        pauseMenuUI.SetActive(false);
        confirmUI.SetActive(true);
    }

    public void YesPressed()
    {
        if (selectedMode == mode.mainMenu)
        {
            SceneManager.LoadScene("MainMenu");
        }
        else
        {
            Application.Quit();
        }
    }
    
    public void NoPressed()
    {
        confirmUI.SetActive(false);
        pauseMenuUI.SetActive(true);
    }
}
