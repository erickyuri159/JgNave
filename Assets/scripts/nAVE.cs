using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nAVE : MonoBehaviour
{
    private float meuTempo;
    GameObject Missil;
    public void mover(string lado)
    {
        if (lado == "Direito") 
        {
            transform.position = new Vector3(transform.position.x + 0.01f, transform.position.y, transform.position.z);
        }


        if (lado == "Esquerdo")
        {
            transform.position = new Vector3(transform.position.x - 0.01f, transform.position.y, transform.position.z);
        }



    }
    private void Update()
    {
        SeguirDedo();
        Disparar();
    }
    public void SeguirDedo()
    {
        if (Input.GetMouseButton(0))
        {
            // pegar posição mause
            Vector3 destino = Input.mousePosition;
            //transformar posição tela 
            Vector3 PosTela = Camera.main.ScreenToWorldPoint(destino);
            Vector3 PosTelaCorrigida = new Vector3(PosTela.x, PosTela.y+0.5f, 0 ); 

            // mover

            transform.position = Vector3.MoveTowards(transform.position, PosTelaCorrigida, 0.01f);
        }
    }
    public void Disparar()
    {

    
    meuTempo += Time.deltaTime;
        if (meuTempo > 0.7f)
        {
          Vector3 Arma1 = new Vector3(transform.position.x -0.5f, transform.position.y, transform.position.z);
            GameObject Arma = Instantiate(Missil, Arma1, Quaternion.identity);
            Destroy(Arma, 3f );
            meuTempo = 0;
        }
        }
}
