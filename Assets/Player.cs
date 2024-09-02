using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private float horizontal;
    private bool isFacingRight = true;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        Debug.Log(horizontal);

        rb.velocity = new Vector2(horizontal * 8f, this.rb.velocity.y);

       

        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.rb.AddForce(Vector2.up * 15f, ForceMode2D.Impulse);
            Debug.Log("Tecla espa�o pressionada");
        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Bot�o direito clicado");
        }
        Flip();
    }
    private void Flip ()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1;
            transform.localScale = localScale;
        }
    }
}
