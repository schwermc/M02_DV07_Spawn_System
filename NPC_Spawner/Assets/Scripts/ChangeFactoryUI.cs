using UnityEngine;
using UnityEngine.UI;

public class ChangeFactoryUI : MonoBehaviour
{
    public GameObject village;
    public GameObject city;

    public void ChangeFactories()
    {
        if (village.activeSelf)
        {
            village.SetActive(false);
            city.SetActive(true);
        }
        else if (city.activeSelf)
        {
            village.SetActive(true);
            city.SetActive(false);
        }
    }
}
