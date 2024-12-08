using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBulletSprite : MonoBehaviour
{
	public Sprite uiImage;
	public SpriteRenderer spriteRender;

    private void Start()
    {
		spriteRender = gameObject.GetComponent<SpriteRenderer>();
	}


	void OnTriggerEnter2D(Collider2D player)
	{
		if (player.CompareTag("Player"))
		{
			Debug.Log("Change Boss Bullet 1");
			spriteRender.sprite = uiImage;
		}
	}
}
