using Mono.Cecil;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour

{
    public int hp;
    public int pontos;
    public GameObject Explosao;
    public GameObject Moeda;
    
   
    public void TomouDano(int dano)
    {
        hp = hp - dano;
        if (hp < 0 )
        {
            ControladorJogo CJ = GameObject.FindGameObjectWithTag("GameController").GetComponent<ControladorJogo>();
            CJ.GanhaPontos(pontos);

            GameObject exp = Instantiate(Explosao, transform.position,Quaternion.identity);
            //destroy explosao
            Destroy(exp, 3f);
            //destroy asteroid
            Destroy(gameObject);




            GameObject moeda = Instantiate(Moeda, transform.position, Quaternion.identity);
            //destroy explosao
            Destroy(moeda, 5f);
            //destroy asteroid
            Destroy(gameObject);
        }
    }
    
    

    
}
