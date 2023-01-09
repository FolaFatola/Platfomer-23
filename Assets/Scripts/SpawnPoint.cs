using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public BoxCollider2D spawnPointCollider;
    public Rigidbody2D platformRigidBody;
    public Vector3 spawnPointPosition;

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        spawnPointPosition = transform.position;
    }

    // Update is called once per frame
    public virtual void Update()
    {
        Move();
        spawnPointPosition = transform.position;
    }

    public void Move()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            transform.Translate(new Vector2(0, 1));
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            transform.Translate(new Vector2(0, -1));
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider == Border.Instance.topBorder)
        {
            transform.Translate(new Vector2(0, -1));
        }
        else if(collider == Border.Instance.bottomBorder)
        {
            transform.Translate(new Vector2(0, 1));
        }
    }
}
