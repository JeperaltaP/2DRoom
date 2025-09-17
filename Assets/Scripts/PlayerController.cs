using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; //variable para guardar la velocidad
    public int score = 0;
    public bool hasKey = false;
    public bool hasWater = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //leer las teclas WASD o las flechas
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        //creamos un vector para direccion del movimiento
        Vector3 direction = new Vector3(moveHorizontal, moveVertical, 0);  

        transform.Translate(direction * speed * Time.deltaTime);

    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Collectable"))
        {
            score = score + 1; //igual a: score+=1 ; score ++;

            Destroy(other.gameObject);
            Debug.Log("Collected!!!");
            Debug.Log("Score: " + score);
        }
        
        if (other.CompareTag("Key"))
        {
            hasKey = true;
            Debug.Log("Key Collected!");
            Destroy(other.gameObject);
        }

        //condición de victoria
        if (score >= 3 && hasKey && !hasWater) // el && significa "y", el || significa "o"; como en lógica: V||V = V, V||F = V, F||F = F
        {
            Debug.Log("Has ganado, no has tocado el agua, tienes suficientes puntos y la llave!");
        }
        // para booleanos, si se pone el nombre de la variable sola, se asume si es verdadero, si tiene "!" delante, se asume si es falso
        
        if (other.CompareTag("Water"))
        {
            hasWater = true;
            Debug.Log("Muelto");
            Destroy(gameObject);
        }
    }
}
