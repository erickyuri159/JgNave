using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFundo : MonoBehaviour
{
    public float MeuTempo;
    public GameObject irmao;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MeuTempo += Time.deltaTime;
        //avançar no tempo
        if ( MeuTempo > 0.01f )
        {
            transform.position = transform.position + new Vector3(0, -0.01f, 0);
            MeuTempo = 0;
        }
        // muda posição
        if (transform.position.y < -5.21)
        {
            transform.position = new Vector3(0, irmao.transform.position.y + 11.5f, 0);
        }    

        
    }
}
