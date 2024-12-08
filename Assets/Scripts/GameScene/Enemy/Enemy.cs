using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public int maxHealth = 1;
	public int currentHealth = 0;
	public static string Type = "";
	// [SerializeField] EnemyHealthBar healthBar;

	[SerializeField] private AudioSource enemyDeathEffectSound;


	[SerializeField] private AudioSource enemydamagedEffectSound;


	private void Awake()
    {
		//healthBar = GetComponentInChildren<EnemyHealthBar>(); 
    }


    public void Start() {

		        currentHealth = maxHealth;

	}

	public void TakeDamage (int damage)
	{

		currentHealth -= damage;
		//healthBar.UpdateHealtBar(currentHealth, maxHealth);

		if (Type == "Test")
		{	
			enemydamagedEffectSound.Play();
			Debug.Log("Test Soundeffect");

		}

		if (Type == "Test")
		{
			enemydamagedEffectSound.Play();
			Debug.Log("Test Soundeffect");

		}

		if (Type == "Test")
		{
			enemydamagedEffectSound.Play();
			Debug.Log("Test Soundeffect");

		}




		if (currentHealth <= 0)
		{
			Die();
		}
	}

	void Die ()
	{

		enemyDeathEffectSound.Play();
		Destroy(gameObject);
		//	Instantiate(deathEffect, transform.position, Quaternion.identity);
		
	}

}
