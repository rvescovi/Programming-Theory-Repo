using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyYellow : Enemy // INHERITANCE
{
    // Start is called before the first frame update
    void Start()
    {
        Title = "Yellow"; // ENCAPSULATION
        Speed = 4.0f; // ENCAPSULATION
        Position = 5.0f; // ENCAPSULATION
    }

    override public void MoveObject() // POLYMORPHISM
    {
        if (transform.position.x > 10)
            transform.position = new Vector3(-10, transform.position.y , Random.Range(-Position, Position));

        transform.Translate(Vector3.right * Time.deltaTime * Speed);
    }
}
