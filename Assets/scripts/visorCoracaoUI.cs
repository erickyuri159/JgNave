using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class visorCoracaoUI : MonoBehaviour
{
    private ControladorJogo CJ;
    private RectTransform rtImagem;
    // Start is called before the first frame update
    void Start()
    {
        CJ = GameObject.FindGameObjectWithTag("GameController").GetComponent<ControladorJogo>();


        rtImagem = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        float tamanhoAjustado = CJ.Armadura * 100;
        rtImagem.sizeDelta = new Vector2(tamanhoAjustado, 100);
        
    }
}
