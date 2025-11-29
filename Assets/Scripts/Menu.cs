using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public int numberScene;
    public GameObject panelOptions;
    public GameObject panelAchievements;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(numberScene);
    }

    public void Options()
    {
        panelOptions.SetActive(true);
    }

    public void ReturnBack()
    {
        panelOptions.SetActive(false);
        panelAchievements.SetActive(false);
    }

    public void Achievements()
    {
        panelAchievements.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Hasta nunca...");
    }
}
