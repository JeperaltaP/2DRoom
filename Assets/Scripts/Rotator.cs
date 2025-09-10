using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 90f; //para controlar la velocidad de rotación

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
