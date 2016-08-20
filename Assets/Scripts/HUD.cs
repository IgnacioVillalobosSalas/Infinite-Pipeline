using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

	public Text distanceLabel, velocityLabel;

	public void SetValues (float distanceTraveled, float velocity) {
		distanceLabel.text = "Score : " + ((int)(distanceTraveled * 10f)).ToString();
		velocityLabel.text = "Speed : " + ((int)(velocity * 10f)).ToString();
	}
}