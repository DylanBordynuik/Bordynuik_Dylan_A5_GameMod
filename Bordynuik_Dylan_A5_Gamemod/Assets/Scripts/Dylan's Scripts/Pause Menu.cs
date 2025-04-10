using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseScreen;
    public bool pauseOn;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            pauseOn = !pauseOn;
        }

        if (pauseOn)
        {

            PauseGame();
            Time.timeScale = 0f;

        }
        else
        {

            UnpauseGame();
            Time.timeScale = 1.0f;

        }
    }

    void PauseGame()
    {

        pauseScreen.SetActive(true);

    }

    void UnpauseGame()
    {

        pauseScreen.SetActive(false);

    }

}
