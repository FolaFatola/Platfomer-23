using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{

    public static Border Instance;

    public Collider2D leftBorder;
    public Collider2D rightBorder;
    public Collider2D topBorder;
    public Collider2D bottomBorder;

     void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
