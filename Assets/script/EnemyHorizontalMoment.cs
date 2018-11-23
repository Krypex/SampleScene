using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMoment : MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody2D rbody;
    public bool Left = true;
   

    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
  
        if (Left == true)
        {
            rbody.velocity = (-(Vector2)transform.right * speed);
            
            transform.localScale = new Vector3(1, 1, 1);
        }

        else
        {
            rbody.velocity = ((Vector2)transform.right * speed);
        
            transform.localScale = new Vector3(-1, 1, 1);

        }

      
    }
    // Update is called once per frame
    void Update()
    {
    }
  
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "InvisibleWall")
        {
            Left = !Left;

        }
      
    }
}





















// transform.right = används i 3D inte 2D
// (Vector2)transfrom blir VEctor2.right
// Casting = rbody.MovePosition(rbody.position + (-(Vector2)transform.right * Time.deltaTime));
//  private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    Left = !Left;
    //}