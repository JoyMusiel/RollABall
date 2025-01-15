using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody sphereRigidBody;
    public float ballSpeed = 2f;
    void Start()
    {

    }

    void Update()
    {
        Vector2 inputVector = Vector2.zero; // initialize the input vector
        if (Input.GetKey(KeyCode.W))
        {
            inputVector += Vector2.up;
        }

        if (Input.GetKey(KeyCode.S))
        {
            inputVector += Vector2.down;
        }

        if (Input.GetKey(KeyCode.D))
        {
            inputVector += Vector2.right;
        }

        if (Input.GetKey(KeyCode.A))
        {
            inputVector += Vector2.left;
        }

        Vector3 inputXZPlane = new(inputVector.x, 0, inputVector.y);
        sphereRigidBody.AddForce(inputXZPlane * ballSpeed);
        Debug.Log("Resultant Vector: " + inputVector);
        Debug.Log("Resultant 3D Vector: " + inputVector);
    }
}
