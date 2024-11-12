using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteBackground : MonoBehaviour
{
    public float velocidadeDoCenario;
  

    // Update is called once per frame
    void Update()
    {
        MovimentCenario();
    }

    private void MovimentCenario()
    {
        Vector2 deslocamento = new Vector2(Time.time * velocidadeDoCenario, 0);
        GetComponent<Renderer>().material.mainTextureOffset = deslocamento;
    }
}
