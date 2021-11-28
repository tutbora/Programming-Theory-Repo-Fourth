using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : Meat
{
    public int count;
    // Start is called before the first frame update
    void Start()
    {
        energy = 5;
        timeActivity = 4;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
