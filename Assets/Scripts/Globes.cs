using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print($"{gameObject.name} GLOBAL POS {transform.position}");
        print($"{gameObject.name} LOCAL POS {transform.localPosition}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
