using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public Text text;

    private string title = "(none)";
    private float speed = 2.0f;
    private float zPosition = 0;

    public string Title { get { return this.title; } set { this.title = value; text.text = this.title; } }
    public float Speed { get { return this.speed; } set { this.speed = value; } }
    public float Position { get { return this.zPosition; } set { this.zPosition = value; 
               transform.position = new Vector3(0, 0, this.zPosition); } }

    // Update is called once per frame
    void Update()
    {
        MoveObject();
    }

    virtual public void MoveObject()
    {
        if (transform.position.x > 10)
            transform.position = new Vector3(-10, transform.position.y, zPosition);

        transform.Translate(Vector3.right * Time.deltaTime * speed);

    }
}
