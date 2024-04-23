using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJogo : MonoBehaviour
{
    public float pontos;
    public float moedas;
    public float Armadura = 3;
    public bool GameLigado= true;
    public GameObject TelagameOver;



    void Start()
    {
        GameLigado = false;
        Time.timeScale = 0;
        if (PlayerPrefs.HasKey("moeda"))
        {
            moedas = PlayerPrefs.GetFloat("moeda");
        }else
        {
            PlayerPrefs.SetFloat("moeda",0);
        }
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GanhaPontos(float novoponto)
    {
        pontos = pontos + novoponto;
    }
    public void GanhaMoedas(float Novamoedas)
    {
        moedas = PlayerPrefs.GetFloat("moeda");
        moedas = moedas + Novamoedas;
        PlayerPrefs.SetFloat("moeda", moedas);
    }
    public void tomarDano()
    {
        Armadura--;
        if (Armadura < 0)
        {
            PararJogo();
            TelagameOver.SetActive(true);
        }
    }
    public void PararJogo()
    {
        GameLigado = false;
        Time.timeScale = 0;
    }
    public void IniciarJogo()
    {
        GameLigado = true;
        Time.timeScale = 1;
    }

}
