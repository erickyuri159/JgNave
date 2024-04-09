using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class nAVE : MonoBehaviour
{
    private float meuTempo;
    public List<Sprite> AeroNaves;
   public GameObject Missil;
    private ControladorJogo CJ;
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
    private void Start()
    {
        GetComponent<SpriteRenderer>().sprite = AeroNaves[0];
        CJ = GameObject.FindGameObjectWithTag("GameController").GetComponent<ControladorJogo>();
    }
    private void Update()
    {
        if (CJ.GameLigado == true)
        {
            EscolherNave();
            SeguirDedo();
            Disparar();
        }
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

            transform.position = Vector3.MoveTowards(transform.position, PosTelaCorrigida, 0.1f);
        }
    }
    public void Disparar()
    {
        meuTempo += Time.deltaTime;
        if (meuTempo > 0.7f)
        {
            //tiro1
          Vector3 Arma1 = new Vector3(transform.position.x -0.5f, transform.position.y, transform.position.z);
            GameObject ArmaLancada1 = Instantiate(Missil, Arma1, Quaternion.identity);
            Destroy(ArmaLancada1, 3f );
           
        
        //tiro2
            Vector3 Arma2 = new Vector3(transform.position.x + 0.5f, transform.position.y, transform.position.z);
            GameObject ArmaLancada2 = Instantiate(Missil, Arma2, Quaternion.identity);
            Destroy(ArmaLancada2, 3f);

            meuTempo = 0;
        }
    }
    public void EscolherNave()
    {
        float pontosQeuTenho = CJ.pontos;
        if (pontosQeuTenho > 5000) 
        {
            GetComponent<SpriteRenderer>().sprite = AeroNaves[4];
        }
        else if (pontosQeuTenho > 3000)
        {
            GetComponent<SpriteRenderer>().sprite = AeroNaves[3];
        }
        else if (pontosQeuTenho > 1500)
        {
            GetComponent<SpriteRenderer>().sprite = AeroNaves[2];
        }
        else if (pontosQeuTenho > 1000)
        {
            GetComponent<SpriteRenderer>().sprite = AeroNaves[1];
        }
        else if (pontosQeuTenho > 500)
        {
            GetComponent<SpriteRenderer>().sprite = AeroNaves[0];
        }
    }
    private void OnTriggerEnter2D(Collider2D colidiu)
    {if (colidiu.gameObject.tag == "moeda")
        {
            Destroy(colidiu.gameObject);
            CJ.GanhaMoedas(5);
        }
     if (colidiu.gameObject.tag == "Asteroid")
        {
            Destroy(colidiu.gameObject);
            CJ.tomarDano();
        }
    }
}
