using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRed : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        Title = "Red";
        Speed = 3.0f;
        Position = -0.0f;
    }
}
