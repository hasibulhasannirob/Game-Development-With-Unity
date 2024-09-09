using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public Color obstracleColor = Color.cyan;

    void OnCollisionEnter(Collision collision)
    {
        Renderer obstRenderer = collision.gameObject.GetComponent<Renderer>();  
        if(collision.collider.tag == "Obstracle")
        {
            obstRenderer.material.color = obstracleColor;
            movement.enabled = false;

            FindAnyObjectByType<GameManager>().EndGame();
        }
    }
}
