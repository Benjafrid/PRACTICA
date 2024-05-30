using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlquilerVehiculos : MonoBehaviour
{
    public GameObject[] vehiculos;
    int vehiculosrandom;

    // Start is called before the first frame update
    void Start()
    {
        ResetearVehiculos();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            vehiculosrandom = Random.Range(0, vehiculos.Length);
            DeactivateVehiculos();
            vehiculos[vehiculosrandom].SetActive(true);
        }   
    }
    void ResetearVehiculos()
    {
        DeactivateVehiculos();
        vehiculos[0].SetActive(true);
    }
    void DeactivateVehiculos()
    {
        for(int i = 0; i<vehiculos.Length; i++)
        {
            vehiculos[i].SetActive(false);
        }
    }
}
