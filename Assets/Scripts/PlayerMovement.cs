using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] float rotationSpeed;

    void Update()
    {
        Movement();
        Rotation();
    }
    
    void Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += this.transform.forward * movementSpeed * Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position += -1 * this.transform.forward * movementSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position += -1 * this.transform.right * movementSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += this.transform.right * movementSpeed * Time.deltaTime;
        }
    }

    void Rotation()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.rotation *= Quaternion.Euler(0,-1 * rotationSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.rotation *= Quaternion.Euler(0,rotationSpeed * Time.deltaTime, 0);
        }
    }
}
