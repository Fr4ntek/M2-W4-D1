using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Esercizio1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player p1 = new Player();
        p1.name = "Franco";
        p1.points = 100;

        Player p2 = new Player();
        p2.name = "Dave";
        p2.points = 75;

        Debug.Log("Player 1: " + p1.name + " " + p1.points);
        Debug.Log("Player 2: " + p2.name + " " + p2.points);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
