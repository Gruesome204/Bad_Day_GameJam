using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    private Animator mAnimator;

    [SerializeField] private float playerSpeed = 6.0f;
    [SerializeField] private float jumpPower = 14.0f;
    [SerializeField] public float dashForce = 10f;

	[SerializeField] public static bool isGrounded = true;

	private bool m_FacingRight = true;
    
    private Rigidbody2D _playerRigidbody;

    private float horizontalInput;

    [SerializeField] private AudioSource jumpSoundeffect;
    [SerializeField] private AudioSource movementSoundEffect;

    private void Start()
    {
        mAnimator = GetComponent<Animator>();
        isGrounded = true;

        _playerRigidbody = GetComponent<Rigidbody2D>();

        if (_playerRigidbody == null)
        {
            Debug.LogError("Player is missing a Rigidbody2D component");
        }
    }

    private void Update()
    {

        if (mAnimator != null)
        {

            MovePlayer();
            mAnimator.SetFloat("Speed", Mathf.Abs(horizontalInput * playerSpeed));
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Dash();
        }

            if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            isGrounded = false;
            JumpPlayer();

        }
    }

	public void JumpPlayer(){

           // mAnimator.SetTrigger("");
            _playerRigidbody.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
		    isGrounded = false;
            jumpSoundeffect.Play();
	}

    public void Dash()
    {
        _playerRigidbody.AddForce(new Vector2(_playerRigidbody.velocity.x * dashForce, _playerRigidbody.velocity.y));
    }



    private void MovePlayer()
    {
         horizontalInput = Input.GetAxisRaw("Horizontal");
        _playerRigidbody.velocity = new Vector2(horizontalInput * playerSpeed, _playerRigidbody.velocity.y);

        if (horizontalInput > 0 && !m_FacingRight)
			{
				// ... flip the player.
				Flip();
			}
			// Otherwise if the input is moving the player left and the player is facing right...
			else if (horizontalInput < 0 && m_FacingRight)
			{
				// ... flip the player.
				Flip();
			}
    }


    //Player is 
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Ground"))
        {
         
           // Debug.Log("EnteredGround");
            isGrounded = true;
        }
    }

    private void Flip()
	{
		    //Switch the way the player is labelled as facing.
		m_FacingRight = !m_FacingRight;

		transform.Rotate(0f, 180f, 0f);
        GameObject.Find("BulletCanvas").transform.Rotate(0f, 180f, 0f);
    }
    


   
}