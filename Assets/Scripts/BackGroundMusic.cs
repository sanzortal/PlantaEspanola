using UnityEngine;

public class BackGroundMusic : MonoBehaviour
{
    static BackGroundMusic backGroundMusic;

    private void Awake()
    {
        if(backGroundMusic == null)
        {
            backGroundMusic = this;
            DontDestroyOnLoad(backGroundMusic);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
