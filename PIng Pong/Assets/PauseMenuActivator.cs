using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PauseMenuActivator : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject restartButton;

    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Pause()
    {
        
        pauseMenu.SetActive(true);
        restartButton.SetActive(true);
        Time.timeScale = 0;
        Debug.Log("Pause");
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        Debug.Log("Resume");
    }
    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("Restart");
    }
}
