using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyYellow : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        Title = "Yellow";
        Speed = 4.0f;
        Position = 5.0f;
    }

    override public void MoveObject()
    {
        if (transform.position.x > 10)
            transform.position = new Vector3(-10, transform.position.y , Random.Range(-Position, Position));

        transform.Translate(Vector3.right * Time.deltaTime * Speed);
    }
}
