
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform Obstacle;
    public float score;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
     
        score = (400 - Obstacle.position.z);
        scoreText.text = score.ToString("0");
    }
}
