using UnityEngine;

public class PowerupManager : MonoBehaviour
{
    [SerializeField] PowerupSO powerupSO;

    PlayerMovement player;
    
    void Start()
    {
        player = FindAnyObjectByType<PlayerMovement>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    
    {
        int layerIndex = LayerMask.NameToLayer("Player");

        if (collision.gameObject.layer == layerIndex)
        {
            player.ActivatePowerup(powerupSO);
        }
    }
}
