using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update

    public  float DistanciaRelCentroSZ;
    public Vector3 posiBorda;
    public Vector3 posiCentroSZ;
    public float Life;

    void Start()
    {
        Life = 100;
      
}

    // Update is called once per frame
    void Update()
    {
        // Pegando as posições da borda da safezone
        posiBorda = transform.position;
        posiCentroSZ = GameObject.FindWithTag("CentroSafeZone").transform.position;

        //  travando as variaveis para nao haver valores negativos
        if (posiBorda.x < 0)
        {
            posiBorda.x = -posiBorda.x;
        }
        if (posiBorda.z < 0)
        {
            posiBorda.z = -posiBorda.z;
        }

        if (posiCentroSZ.x < 0)
        {
            posiCentroSZ.x = -posiCentroSZ.x;
        }
        if (posiCentroSZ.z < 0)
        {
            posiCentroSZ.z = -posiCentroSZ.z;
        }


        // sempre deixar o eixo Y em Zero

        posiBorda.y = 0;
        posiCentroSZ.y = 0;


        // pegando a distancia do centro em relação a borda da safezone ponto (A) e ponto (B)
        DistanciaRelCentroSZ = Vector3.Distance(posiBorda, posiCentroSZ);


        // se for maior que a posição da borda receber dano do Gaz

        if(DistanciaRelCentroSZ > SafeZone.DistanciaRelCentroSZ)
        {
            Life -= 1 * Time.deltaTime;

        }

    }

    private void OnGUI()
    {
        GUI.TextField(new Rect(10, 30, 130, 20), "Distancia da Safezone: " + posiCentroSZ);
        GUI.TextField(new Rect(500, 700, 130, 20), "Vida do Player: " + Life);
    }
}
}
