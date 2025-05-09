using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player p1 = new Player();
        p1.name = "Franco";
        p1.points = 0;
        Debug.Log("Punteggio PRE incremento: " +  p1.points);
        p1.IncrementaPunteggio(ref p1.points);
        Debug.Log("Punteggio POST incremento: " + p1.points);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 
}
