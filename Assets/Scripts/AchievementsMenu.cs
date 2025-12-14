using System;
using UnityEngine;
using UnityEngine.UI;

public class AchievementsMenu : MonoBehaviour
{
    [System.Serializable]
    public class AchievementVisual
    {
        public Image image;
        public Sprite lockedAchievement;
        public Sprite unlockedAchievement;
    }

    [SerializeField]
    private AchievementVisual[] achievements;

    private void Start()
    {
        UpdateIcons();
    }

    public void UpdateIcons()
    {
        for (int i = 0; i < achievements.Length; i++)
        {
            int unlocked = PlayerPrefs.GetInt("achievement_" + i, 0);

            if (unlocked == 1)
            {
                achievements[i].image.sprite = achievements[i].unlockedAchievement;
            }
            else
            {
                achievements[i].image.sprite = achievements[i].lockedAchievement;
            }
        }
    }
}
