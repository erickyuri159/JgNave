using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missil : MonoBehaviour
{
    public int Dano;
    // Start is called before the first frame update
  
    

    private void OnTriggerEnter2D(Collider2D colidiu)

    {
        if (colidiu.gameObject.tag == "Asteroid")

        {
            colidiu.gameObject.GetComponent<Asteroid>().TomouDano(Dano);
            Destroy(gameObject);
        }
        
    }
}
