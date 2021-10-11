using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirDrop : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Paraquedas;
    public GameObject fumacaAzul;

    void Start()
    {
        fumacaAzul.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        fumacaAzul.SetActive(true);
        Paraquedas.SetActive(false);
    }

}
