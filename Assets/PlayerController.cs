using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float sideSpeed = 3f;

    private Vector3 moveDirection;

    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * sideSpeed * Time.deltaTime);

        float xPos = Mathf.Clamp(transform.position.x, -5f, 5f);
        transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
    }


    private void OnCollisionEnter3D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Respawn")
        {

            SceneManager.LoadScene("Defeat");
        }
    }
}

