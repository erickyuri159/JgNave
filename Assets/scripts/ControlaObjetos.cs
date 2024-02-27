using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ControlaObjetos : MonoBehaviour
{   public float meuTempo;
    public List<GameObject> MeuObjeto;
   
    void Start()
    {
       
    }

    
    void Update()
    {
        meuTempo += Time.deltaTime;
        if ( meuTempo > 0.7f)
        {
            //definir x

            float valX = Random.Range(-1.7f, 1.7f);

            // posição
            Vector3 novaPost = new Vector3(valX, 7, 0);
            //sorteiador
            int indicador = Random.Range(0, MeuObjeto.Count);

            GameObject Pedra = Instantiate(MeuObjeto[indicador], novaPost, Quaternion.identity);        
            //tempo destruir
            Destroy( Pedra, 3f );
            meuTempo = 0;
        }
        
    }
}
