using UnityEngine;

public class MovementObj : MonoBehaviour
{
    private GameManager gameManager;
    private float distans;
    private float speed;
  
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        distans = gameManager.ChekInput(gameManager.Distans);
        speed = gameManager.ChekInput(gameManager.Speed);
    }

    
    void Update()
    {
        if(gameManager != null)
        {
            transform.Translate(new Vector3(distans, 0, 0) * speed * Time.deltaTime);
            if (transform.position.x >= distans)
            {
                Destroy(gameObject);
            }
        }
    }
}
