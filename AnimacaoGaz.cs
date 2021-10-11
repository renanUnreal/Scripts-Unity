using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimaDanoGás : MonoBehaviour
{
    public Texture2D[] textura;
    public float valor;
    public int ValorInt;
    public float t;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //esqueminha basico de efeito de dano do gás 
        //criado por Marcos DS
        t += Time.deltaTime;
        if (t > 1)
        {
            ValorInt = Mathf.FloorToInt(valor = 10 * Random.value);
            t = 0;
        }
        transform.GetComponent<Renderer>().material.mainTexture = textura[ValorInt];
    }
}
