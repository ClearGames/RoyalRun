using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] float checkpointTimeExtension = 5.0f;
    [SerializeField] GameManager gameManager;
    const string playerString = "Player";

    private void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerString))
        {
            gameManager.IncreaseTime(checkpointTimeExtension);
        }
    }
}
