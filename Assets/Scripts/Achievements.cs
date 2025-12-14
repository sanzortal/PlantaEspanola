using System.Collections;
using UnityEngine;

public class Achievements : MonoBehaviour
{
    [SerializeField]
    private GameObject panelUnlocked;
    [SerializeField]
    private GameObject[] achievementUI;
    [SerializeField] AudioSource notificactionSound;

    //[SerializeField]
    //private Animator animator;

    /*
     * ACHIEVEMENTS:
     * 0 = Feto
     * 1 = Ninio
     * 2 = Adolescente
     * 3 = Adulto
     * 4 = Viejo
     * 5 = Tumba
     */

    public void UnlockAchiviement(int id)
    {
        // in case that the achievement was unlocked
        if (PlayerPrefs.GetInt("achievement_" + id, 0) == 1)
        {
            return;
        }

        PlayerPrefs.SetInt("achievement_" + id, 1);


        for (int i = 0; i < achievementUI.Length; i++)
        {
            achievementUI[i].SetActive(i == id);
        }
        
        StartCoroutine(NotificationCoroutine());


    }

    IEnumerator NotificationCoroutine()
    {
        panelUnlocked.SetActive(true);
        notificactionSound.Play();
        yield return new WaitForSeconds(1f);
        panelUnlocked.SetActive(false);
    }

}
