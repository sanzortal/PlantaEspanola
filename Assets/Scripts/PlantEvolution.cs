using UnityEngine;
using UnityEngine.UI;

public class PlantEvolution : MonoBehaviour
{
    [SerializeField] GameObject FetoPlanta;
    [SerializeField] GameObject NinioPlanta;
    [SerializeField] GameObject AdolescentePlanta;
    [SerializeField] GameObject AdultoPlanta;
    [SerializeField] GameObject ViejoPlanta;
    [SerializeField] GameObject Tumba;

    [SerializeField] Button wateringCan;

    [SerializeField] Achievements achievements;

    private int irrigation = 0;
    private Vector3 positionPlant = new Vector3(120, 1031.54443f, 441.378296f);

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
        }
        
        if(irrigation == 3)
        {
            Destroy(GameObject.Find("FetoPlanta"));
            Instantiate(NinioPlanta, positionPlant, Quaternion.identity); // ahora es ninio
            achievements.UnlockAchiviement(1);
        }
        else if (irrigation == 6)
        {
            Destroy(GameObject.Find("NinioPlanta(Clone)"));
            Instantiate(AdolescentePlanta, positionPlant, Quaternion.identity); // ahora es adolescente
            achievements.UnlockAchiviement(2);
        }
        else if (irrigation == 9)
        {
            Destroy(GameObject.Find("AdolescentePlanta(Clone)"));
            Instantiate(AdultoPlanta, positionPlant, Quaternion.identity); // ahora es adulto
            achievements.UnlockAchiviement(3);
        }
        else if (irrigation == 12)
        {
            Destroy(GameObject.Find("AdultoPlanta(Clone)"));
            Instantiate(ViejoPlanta, positionPlant, Quaternion.identity); // ahora es viejo
            achievements.UnlockAchiviement(4);
        }
        else if (irrigation == 15)
        {
            Destroy(GameObject.Find("ViejoPlanta(Clone)"));
            Instantiate(Tumba, positionPlant, Quaternion.identity); // aparece la tumba (se muere)
            wateringCan.interactable = false; // deja de interactuar con el botón
            achievements.UnlockAchiviement(5);
        }
    }
}
