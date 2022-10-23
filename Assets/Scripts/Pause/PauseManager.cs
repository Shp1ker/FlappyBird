using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public GameObject Bird;
    public GameObject Panel;
    public GameObject GameOverPanel;
    public GameObject ContinueButton;
    [SerializeField] Transform birdMover;
    [SerializeField] Transform BGMover;
    [SerializeField] Transform GroundMover;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            OpenPanel();
        }
    }

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
    public void Menu()
    {
        SceneManager.LoadScene(1);
    }
    public void Restart()
    {
        Sprite spr = Bird.GetComponent<SpriteRenderer>().sprite;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Bird.GetComponent<SpriteRenderer>().sprite = spr;
    }
}
