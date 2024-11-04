using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI; // Arrastra aqu� el objeto "PauseMenu" desde el Inspector
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
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
        Cursor.lockState = CursorLockMode.Locked;
        pauseMenuUI.SetActive(false);  // Oculta el men� de pausa
        Time.timeScale = 1f;           // Restablece el tiempo normal
        isPaused = false;
    }

    void Pause()
    {
        Cursor.lockState= CursorLockMode.None;
        pauseMenuUI.SetActive(true);   // Muestra el men� de pausa
        Time.timeScale = 0f;           // Detiene el tiempo del juego
        isPaused = true;
    }

    public void QuitGame()
    {
        // Aqu� puedes a�adir el c�digo para salir del juego o volver al men� principal
        Debug.Log("Saliendo del juego...");
        Application.Quit();
    }
}
