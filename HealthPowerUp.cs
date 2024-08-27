using UnityEngine;

public class HealthPowerUp : MonoBehaviour
{
    [SerializeField] private FloatData healthValue;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //appies the health value to the player
            ApplyHealth(other.gameObject);
            
            //Destroys the power-up game object
            Destroy(gameObject);
        }
    }

    private void ApplyHealth(GameObject player)
    {
        //Retrieve the player's health component (e.g., HealthController script)
        HealthController healthController = player.GetComponent<HealthController>();
        
        //check if the player has a health component
        if (healthController !=null)
        {
            //add the health value to the player's current health
            healthController.AddHealth(healthValue.Value);
        }
    }
}
