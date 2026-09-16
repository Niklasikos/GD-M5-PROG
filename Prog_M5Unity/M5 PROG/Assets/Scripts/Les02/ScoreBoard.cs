using TMPro;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    private TextMeshProUGUI textScore;
    private int Score;
    void Awake()
    {
        textScore = GetComponent<TextMeshProUGUI>();
        textScore.text = "Score: 0";
    }

    void OnEnable()
    {
        Pickup.ScoreAdd += ScoreAdded;
    }

    void OnDisable()
    {
        Pickup.ScoreAdd -= ScoreAdded;
    }

    private void ScoreAdded(int points)
    {
        Score += points;
        textScore.text = $"Score: {Score}";
    }
}
