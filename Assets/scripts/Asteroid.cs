using Mono.Cecil;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour

{
    public int hp;
    public int pontos;
    public GameObject Explosao;
    // Start is called before the first frame update
   
    public void TomouDano(int dano)
    {
        hp = hp - dano;
        if (hp < 0 )
        {
            GameObject exp = Instantiate(Explosao, transform.position,Quaternion.identity);
            //destroy explosao
            Destroy(exp, 3f);
            //destroy asteroid
            Destroy(gameObject);
        }
    }
}
