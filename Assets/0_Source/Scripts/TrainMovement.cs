using UnityEngine;

public class TrainMovement : MonoBehaviour
{
    [SerializeField] private float speed = 10;
    
    
    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
