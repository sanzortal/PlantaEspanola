using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public int numberScene;
    public GameObject panelOptions;
    public GameObject panelAchievements;

    public Image plantaFetoLocked;
    public Sprite plantaFetoUnlocked;

    private bool PlantaFeto;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlantaFeto = PlayerPrefs.GetInt("achievement") == 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlantaFeto == true)
        {
            plantaFetoLocked.sprite = plantaFetoUnlocked;
        }
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
