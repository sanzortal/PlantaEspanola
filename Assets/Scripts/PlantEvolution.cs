using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class PlantEvolution : MonoBehaviour
{
    [SerializeField] GameObject FetoPlanta;
    [SerializeField] GameObject NinioPlanta;
    [SerializeField] GameObject AdolescentePlanta;
    [SerializeField] GameObject AdultoPlanta;
    [SerializeField] GameObject ViejoPlanta;
    [SerializeField] GameObject Tumba;
    [SerializeField] Transform imageTarget;    

    [SerializeField] Button wateringCan;

    [SerializeField] Achievements achievements;
    [SerializeField] AudioSource notificactionSound;

    private int irrigation = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Evolution()
    {
        irrigation++;

        if (irrigation == 1)
        {
            achievements.UnlockAchiviement(0);
            notificactionSound.Play();
        }
        
        if(irrigation == 3)
        {
            Destroy(GameObject.Find("FetoPlanta"));
            Instantiate(NinioPlanta, imageTarget.position, Quaternion.identity, imageTarget); // ahora es ninio
            achievements.UnlockAchiviement(1);
            notificactionSound.Play();
        }
        else if (irrigation == 6)
        {
            Destroy(GameObject.Find("NinioPlanta(Clone)"));
            Instantiate(AdolescentePlanta, imageTarget.position, Quaternion.identity, imageTarget); // ahora es adolescente
            achievements.UnlockAchiviement(2);
            notificactionSound.Play();
        }
        else if (irrigation == 9)
        {
            Destroy(GameObject.Find("AdolescentePlanta(Clone)"));
            Instantiate(AdultoPlanta, imageTarget.position, Quaternion.identity, imageTarget); // ahora es adulto
            achievements.UnlockAchiviement(3);
            notificactionSound.Play();
        }
        else if (irrigation == 12)
        {
            Destroy(GameObject.Find("AdultoPlanta(Clone)"));
            Instantiate(ViejoPlanta, imageTarget.position, Quaternion.identity, imageTarget); // ahora es viejo
            achievements.UnlockAchiviement(4);
            notificactionSound.Play();
        }
        else if (irrigation == 15)
        {
            Destroy(GameObject.Find("ViejoPlanta(Clone)"));
            Instantiate(Tumba, imageTarget.position, Quaternion.identity, imageTarget); // aparece la tumba (se muere)
            wateringCan.interactable = false; // deja de interactuar con el botón
            achievements.UnlockAchiviement(5);
            notificactionSound.Play();
        }
    }
}
