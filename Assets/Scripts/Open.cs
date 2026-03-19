using UnityEngine;

public class Open: MonoBehaviour
{
    public GameObject wallToDisable; // Assign in Inspector

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (wallToDisable != null)
            {
                // Option 1: Disable the whole wall GameObject
                // wallToDisable.SetActive(false);

                // Option 2: Just disable the Collider2D to make it passable
                Collider2D wallCollider = wallToDisable.GetComponent<Collider2D>();
                if (wallCollider != null)
                {
                    wallCollider.enabled = false;
                }

                SpriteRenderer wallSprite = wallToDisable.GetComponent<SpriteRenderer>();
                if (wallSprite != null)
                {
                    wallSprite.enabled = false;
                }
            }
        }
    }
}