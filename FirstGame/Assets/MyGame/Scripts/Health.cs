using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

	public PowerUp PowerUpTransfer;
	public float PowerLevel = 1.0f;
	public Image Healthbar;
	
	public float AddPowerLevel()
	{
		return HealthBar.fillAmount += PowerLevel;
	}
	private void OnTriggerEnter(Collider obj)
	{
		obj.GetComponent<MoveCharacter>().Movement = PowerUpTransfer.Transfer();
		if(HealthBar.fillAmount > 0f);
		{
			PowerLevel = AddPowerLevel();
		}
	gameObject.SetActive(false);
	}

}