using UnityEngine;

public class TargetEvents : MonoBehaviour
{
    [SerializeField] GameObject wateringCan;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTargetFound()
    {
        wateringCan.SetActive(true);
    }

    public void OnTargetLost()
    {
        wateringCan.SetActive(false);
    }
}
