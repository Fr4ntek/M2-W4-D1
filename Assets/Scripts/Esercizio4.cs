using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player p1 = new Player();
        p1.name = "Jinwoo";
        p1.SetLivello(50);

        Enemy e1 = new Enemy();
        e1.SetNome("Baran");
        e1.SetSalute(100);
        e1.SetLivello(40);

        InfliggiDanno(p1 , e1, 90);
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InfliggiDanno(Player p1, Enemy e1, int danno)
    {
        if (p1.GetLivello() >= e1.GetLivello())
        {
            Debug.Log($"Stai attaccando un nemico di livello {e1.GetLivello()}");
            Debug.Log($"Salute nemico prima dell'attacco: {e1.GetSalute()} - Attacco di danno: {danno}");
            e1.SubisciDanno(danno);
            Debug.Log($"Salute nemico dopo l'attacco: {e1.GetSalute()}");
        }
        else
        {
            Debug.Log("Attenzione: non puoi ancora affrontare questo nemico, il tuo livello è troppo basso");
        }
    }
}
