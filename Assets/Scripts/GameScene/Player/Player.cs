using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

	public int maxHealth = 50;
	public int currentHealth = 0;


	[SerializeField] private AudioSource deathSoundEffect;
	[SerializeField] private AudioSource playerDamageSoundEffect;

	public void Start()
	{

		currentHealth = maxHealth;

	}



    //Player takes damage when colliding with enemy
    private void OnCollisionEnter2D(Collision2D collision)
	{
		bool v = collision.gameObject.CompareTag("Enemy");
		if (v)
		{
			TakeDamage(10);
		}
	} 
		


		
	public void TakeDamage(int damage)
	{
		playerDamageSoundEffect.Play();
		   currentHealth -= damage;
		//healthBar.UpdateHealtBar(currentHealth, maxHealth);

		if (currentHealth <= 0)
		{
			Die();
			
		}
	}

	void Die()
	{
		deathSoundEffect.Play();
		Destroy(gameObject);
		SceneManager.LoadScene("GameScene");
		//Instantiate(deathSoundEffect,transform.position, Quaternion.identity);

	}
}
