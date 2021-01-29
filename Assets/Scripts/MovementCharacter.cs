using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCharacter : MonoBehaviour
{

    //public Animator GeysersAnim;
    public Rigidbody2D rb2D;
    //public GameObject geysers;
    public int force = 450;
    public float speed;
    public bool canJump;
    public bool canMoveLeft;
    public bool canMoveRight;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = gameObject.AddComponent<Rigidbody2D>();
        //transform.position = new Vector2(0.0f, -2.0f);
        canJump = true;
    }

    // Update is called once per frame
    void Update()
    {
        //speed = rigidbodyDino.velocity.magnitude;
    if (canJump == true)
    {
        if (Input.GetKeyUp(KeyCode.T))
        {
            rb2D.AddForce(transform.up * force); 
        }

        if (Input.GetKeyUp(KeyCode.Y))
        {
            rb2D.AddForce(transform.up * force); 
            //geysers.GetComponent<Animator>().Play("GeysersAnim");
        }

        if (Input.GetKeyUp(KeyCode.U))
        {
            rb2D.AddForce(transform.up * force); 
        }

        if (Input.GetKeyUp(KeyCode.I))
        {
            rb2D.AddForce(transform.up * force); 
        }
    }
        
    if (canMoveRight == true)
    {
        if (Input.GetKeyUp(KeyCode.O))
        {
            rb2D.AddForce(-transform.right * force); 
            
        }

        if (Input.GetKeyUp(KeyCode.P))
        {
            rb2D.AddForce(-transform.right * force); 
            
        }
    }

    if (canMoveLeft == true)
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            rb2D.AddForce(transform.right * force);            
        }

        if (Input.GetKeyUp(KeyCode.R))
        {
            rb2D.AddForce(transform.right * force);            
        }
    }
}

    void OnCollisionExit2D(Collision2D other)
    {
        canJump = false;
        canMoveLeft = true;
        canMoveRight = true;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        force = 450;
        canJump = true;
        canMoveLeft = false;
        canMoveRight = false;

    }

}
