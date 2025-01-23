using UnityEngine;

public class Coin : Pickup
{
    [SerializeField] int scoreAmount = 100;
    ScoreManager scoreManager;

    //private void Start()
    //{
    //    scoreManager = FindFirstObjectByType<ScoreManager>();
    //}
    public void Init(ScoreManager scoreManager)
    {
        this.scoreManager = scoreManager;
    }

    protected override void OnPickup()
    {
        scoreManager.IncreaseScore(scoreAmount);
    }
}
