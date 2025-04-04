using UnityEngine;

[ExecuteAlways]
public class DayAndNight : MonoBehaviour
{
    Vector3 rotation = Vector3.zero; // Valor inicial da rotação
    float dayCycle = 1.5f; // Graus por segundo

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotation.x = dayCycle * Time.deltaTime; // Quantos segundos levou do último frame ao atual. E ao multiplicá-lo por qualquer cálculo de movimento, se está normalizando esses cálculos
        transform.Rotate(rotation, Space.World);
    }
}
