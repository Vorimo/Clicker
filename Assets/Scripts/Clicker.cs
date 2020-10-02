using UnityEngine;
using UnityEngine.UI;

public class Clicker : MonoBehaviour {

    public int score;

    public Text scoreText;
    // Start is called before the first frame update
    void Start() {
        score = 0;
    }

    public void Click() {
        score++;
        scoreText.text = score.ToString();
    }
}
