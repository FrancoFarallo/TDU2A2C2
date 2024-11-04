using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI; // Arrastra aquí el objeto "PauseMenu" desde el Inspector
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
        pauseMenuUI.SetActive(false);  // Oculta el menú de pausa
        Time.timeScale = 1f;           // Restablece el tiempo normal
        isPaused = false;
    }

    void Pause()
    {
        Cursor.lockState= CursorLockMode.None;
        pauseMenuUI.SetActive(true);   // Muestra el menú de pausa
        Time.timeScale = 0f;           // Detiene el tiempo del juego
        isPaused = true;
    }

    public void QuitGame()
    {
        // Aquí puedes añadir el código para salir del juego o volver al menú principal
        Debug.Log("Saliendo del juego...");
        Application.Quit();
    }
}
