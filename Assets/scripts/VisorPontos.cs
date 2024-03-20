using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VisorPontos : MonoBehaviour
{
    private ControladorJogo CJ;
    private TMP_Text MeuText;

    
    void Start()
    {
        CJ = GameObject.FindGameObjectWithTag("GameController").GetComponent<ControladorJogo>();
        MeuText = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        MeuText.text = "Score: "+CJ.pontos.ToString();
    }
}
