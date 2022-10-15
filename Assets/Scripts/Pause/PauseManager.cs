using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public GameObject Panel;
    public GameObject GameOverPanel;
    public void OpenPanel()
    {
        if (Time.timeScale == 1)
        {
            Pause();
            Panel.SetActive(true);
        }
        else if (GameOverPanel.activeSelf == false)
        {
            Continue();
            Panel.SetActive(false);
        }
    }
    public void Pause()
    {       
        Time.timeScale = 0;
    }

    public void Continue()
    {
        Time.timeScale = 1;
    }
}
