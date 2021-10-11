using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeZone : MonoBehaviour
{
    // Start is called before the first frame update
    public static float DistanciaRelCentroSZ;
    public Vector3 posiBorda;
    public Vector3 posiCentroSZ;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Pegando as posições da borda da safezone
        posiBorda = transform.position;
        posiCentroSZ = GameObject.FindWithTag("CentroSafeZone").transform.position;

        //  travando as variaveis para nao haver valores negativos
        if (posiBorda.x < 0 )
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


       
    }

    private void OnGUI()
    {
        GUI.TextField(new Rect(10, 10, 130, 20), "Distancia da Safezone: " + posiCentroSZ);
    }
}
