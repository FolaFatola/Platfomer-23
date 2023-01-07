using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Overall goal:
 * We want to be able 
 * 
 * 
 */

public class Platform : MonoBehaviour
{

    public BoxCollider2D platformCollider;
    public Rigidbody2D platformRigidBody;

    public Vector2 automaticMoveDirection;

    public string moveMethod;

    public float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        //if automaticmove() is called...
        
        automaticMoveDirection = Vector2.right;

        //If playermove() is called...
    }

    // Update is called once per frame
    void Update()
    {
        if (platformCollider.IsTouching(Border.Instance.rightBorder) | platformCollider.IsTouching(Border.Instance.leftBorder))
            automaticMoveDirection *= -1;

        AutomaticMove();
        //PlayerMove();
    }

    public void PlayerMove()
    {
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector2.right * speed);
        else if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector2.left * speed);
    }

    public void AutomaticMove()
    {
        transform.Translate(automaticMoveDirection*speed);
    }

}
