using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Health : MonoBehaviour {

    public float PowerLevel = 1.0F;
    public Image HealthBar;

    public float AddPowerLevel()
    {
        return HealthBar.fillAmount += PowerLevel;
    }

    public void OnTriggerEnter(Collider obj)
    {
        
        if (HealthBar.fillAmount <= 0F)
        {
             gameObject.SetActive(false);
        }
       
    }


}