using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Player
{
    public string name;
    public int points;

    // Esercizio 3 - per non rompere i precedenti esercizi creo un altra variabile
    private int punteggio;

    // Esercizio 4 - add livello
    private int livello;

    // Esercizio 2 - aggiunto metodo public
    public void IncrementaPunteggio(ref int points)
    {
        Debug.Log("Incremento il punteggio..");
        points++;   
    }

    public int GetPunteggio()
    {
        return punteggio;
    }

    public void SetPunteggio(int punteggio)
    {
        this.punteggio = Mathf.Max(0, punteggio);
    }

    public int GetLivello()
    {
        return livello;
    }

    public void SetLivello(int livello)
    {
        this.livello = livello;
    }

    public bool isVincitore(int punteggio)
    {
        if (punteggio == 100)
        {
            return true;
        }

        return false;
    }

   

}
