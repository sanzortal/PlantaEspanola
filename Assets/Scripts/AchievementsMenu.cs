using System;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class AchievementVisual
{
    public Image achievementsIcons;
    public Sprite lockedAchievement;
    public Sprite unlockedAchievement;
}

public class AchievementsMenu : MonoBehaviour
{
    [SerializeField]
    private AchievementVisual[] achievements;

    private void OnEnable()
    {
        UpdateIcons();
    }

    public void UpdateIcons()
    {
        for (int i = 0; i < achievements.Length; i++)
        {
            bool unlocked = PlayerPrefs.GetInt("achievement_" + i, 0) == 1;

            if (achievements[i].achievementsIcons == null)
            {
                achievements[i].achievementsIcons.sprite = unlocked ? achievements[i].unlockedAchievement : achievements[i].lockedAchievement;
            }
        }
    }
}
