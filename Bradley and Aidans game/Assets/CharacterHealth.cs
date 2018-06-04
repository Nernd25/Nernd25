using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CharacterHealth : MonoBehaviour {
	public float CurrentHealth { get; set; }
	public float MaxHealth { get; set; }

	public Slider healthbar;

	// Use this for initialization
	public void Start () {
		MaxHealth = 100f;
		CurrentHealth = MaxHealth;

		healthbar.value = CalculateHealth ();
	}
	
	// Update is called once per frame

		void OnCollisionEnter(Collision collisionInfo) {
			if (collisionInfo.collider.tag == "enemy")
				DealDamage (10f);
		}
		

	void DealDamage (float damageValue)
	public void DealDamage (float damageValue)
	{
		CurrentHealth -= damageValue; 
		healthbar.value = CalculateHealth ();
		if (CurrentHealth <= 0)
			Die ();
	}

	float CalculateHealth()
	public float CalculateHealth()
	{
		return CurrentHealth / MaxHealth;
	}

	void Die()
	{
		CurrentHealth = 0;
		Debug.Log ("YA DED");
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}

}
