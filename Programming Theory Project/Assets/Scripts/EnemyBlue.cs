using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBlue : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        Title = "Blue";
        Speed = 2.0f;
        Position = -5.0f;
    }
}
