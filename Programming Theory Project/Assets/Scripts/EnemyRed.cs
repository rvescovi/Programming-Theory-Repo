using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRed : Enemy // INHERITANCE
{
    // Start is called before the first frame update
    void Start()
    {
        Title = "Red"; // ENCAPSULATION
        Speed = 3.0f; // ENCAPSULATION
        Position = -0.0f; // ENCAPSULATION
    }
}
