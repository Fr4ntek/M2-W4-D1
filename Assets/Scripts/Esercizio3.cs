using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player p1 = new Player();
        p1.name = "Ciccio";
        p1.SetPunteggio(10);
        Debug.Log("SetPunteggio con numero > 0: " +  p1.GetPunteggio());
        p1.SetPunteggio(0);
        Debug.Log("SetPunteggio con numero = 0: " + p1.GetPunteggio());
        p1.SetPunteggio(-10);
        Debug.Log($"SetPunteggio con numero < 0: {p1.GetPunteggio()}");

        p1.SetPunteggio(99);
        int punteggio = p1.GetPunteggio();
        p1.IncrementaPunteggio(ref punteggio);
        if (p1.isVincitore(punteggio))
        {
            Debug.Log("Il player ha raggiunto 100 punti");
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
