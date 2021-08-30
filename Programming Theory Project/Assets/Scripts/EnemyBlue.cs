using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBlue : Enemy // INHERITANCE
{
    // Start is called before the first frame update
    void Start()
    {
        Title = "Blue"; // ENCAPSULATION
        Speed = 2.0f; // ENCAPSULATION
        Position = -5.0f; // ENCAPSULATION
    } 
}
