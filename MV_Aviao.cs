using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MV_Aviao : MonoBehaviour
{
    // Start is called before the first frame update
    public float tempo;
    public GameObject AirDrop;
    public int ctrlSpawn;
   


    void Start()
    {
        tempo = 0;
        ctrlSpawn = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        tempo += Time.deltaTime;

        

        transform.Translate(Vector3.forward * (-30) * Time.deltaTime);

        if (tempo >= 30)
        {
            Destroy(gameObject);

        }
       
       
            if (tempo > 6 && ctrlSpawn <= 0)
            {
                Instantiate(AirDrop, transform.position, transform.rotation);
            ctrlSpawn = 1;
            }
        }
    
}
