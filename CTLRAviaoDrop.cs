using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTLRAviaoDrop : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform SpawnSE;
    public Transform SpawnNE;
    public Transform SpawnSW;
    public Transform SpawnNW;
    public Transform SpawnW;
    public Transform SpawnE;

    public float tempoSpawn;
    public float SpawnAleatorio;
    public GameObject Aviao;
    void Start()
    {
        tempoSpawn = 0;
       
    }

    // Update is called once per frame
    void Update()
    {
      
        SpawnAleatorio = Random.value;

        // Esquema de Spawn de Avioes
        if (!GameObject.FindWithTag("AviaoAirDrop"))
        {
              tempoSpawn += Time.deltaTime;
            if (tempoSpawn > 10)
        {

            

                // condicao 1
                if (SpawnAleatorio >= 0 && SpawnAleatorio < 0.16)
                {
                    Instantiate(Aviao, SpawnSE.position, SpawnSE.rotation);
                   
                    
                }

                // condicao 2
                if (SpawnAleatorio >= 0.16 && SpawnAleatorio < 0.32)
                {
                    Instantiate(Aviao, SpawnNE.position, SpawnNE.rotation);

                  
                }

                // condicao 3
                if (SpawnAleatorio >= 0.32 && SpawnAleatorio < 0.48)
                {
                    Instantiate(Aviao, SpawnSW.position, SpawnSW.rotation);

                   

                }

                // condicao 4
                if (SpawnAleatorio >= 0.48 && SpawnAleatorio < 0.64)
                {
                    Instantiate(Aviao, SpawnNW.position, SpawnNW.rotation);

                   
                }

                // condicao 5
                if (SpawnAleatorio >= 0.64 && SpawnAleatorio < 0.80)
                {
                    Instantiate(Aviao, SpawnW.position, SpawnW.rotation);

                    
                }

                // condicao 6
                if (SpawnAleatorio >= 0.80 && SpawnAleatorio < 1)
                {
                    Instantiate(Aviao, SpawnE.position, SpawnE.rotation);
                    

                }
                tempoSpawn = 0;
            }
           
        }


    }
   
    
}
