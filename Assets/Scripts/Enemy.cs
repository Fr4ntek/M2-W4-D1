using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{

    private string nome;
    private int salute;
    private int livello;

    public string GetNome()
    {
        return nome;
    }

    public void SetNome(string nome)
    {
        this.nome = nome;
    }

    public int GetSalute()
    {
        return salute;
    }

    public void SetSalute(int salute)
    {
        this.salute = salute;
    }

    public int GetLivello()
    {
        return livello;
    }

    public void SetLivello(int livello)
    {
        this.livello = livello;
    }

    public void SubisciDanno(int danno)
    {
        if(salute >= danno)
        {
            salute -= danno;
        }
        else
        {
            salute = 0;
        }
        
    }

}
