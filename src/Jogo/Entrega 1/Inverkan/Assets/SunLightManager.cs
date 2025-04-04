using UnityEngine;

[ExecuteAlways]
public class DayAndNight : MonoBehaviour
{
    Vector3 rotation = Vector3.zero; // Valor inicial da rota��o
    float dayCycle = 1.5f; // Graus por segundo

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotation.x = dayCycle * Time.deltaTime; // Quantos segundos levou do �ltimo frame ao atual. E ao multiplic�-lo por qualquer c�lculo de movimento, se est� normalizando esses c�lculos
        transform.Rotate(rotation, Space.World);
    }
}
