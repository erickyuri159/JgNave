using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJogo : MonoBehaviour
{
    public float pontos;
    public float moedas;
    
    
    void Start()
    {
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

}
