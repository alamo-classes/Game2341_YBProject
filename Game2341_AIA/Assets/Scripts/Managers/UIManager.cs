using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
//T. Womack 9-2016, 4-2017
public class UIManager : MonoBehaviour
{
	public static int score;
	public static int health;
	private CameraSelect activeCam;

	public Text scoreText;

	public float survive2Win = 180.0f;

	private float wait2Update = 1f;
	private float updateTime;
	private float winTime;


	// Use this for initialization
	void Start ()
	{
		updateTime = Time.time + wait2Update;
		winTime = Time.time + survive2Win;
		activeCam = GetComponent<CameraSelect>();
	}

	// Update is called once per frame
	void Update ()
	{
		if (Time.time > updateTime)
		{
			updateTime = Time.time + wait2Update;
			scoreText.text = "Score: " + score;
			if (Time.time > winTime && !PlayerHealth.isDead)
			{
				Invoke ("loadWinScreen", 1f);
			}
		}
		if (Input.GetKeyDown (KeyCode.P))
		{
			activeCam.selectCam1 ();
		}

		if (Input.GetKeyDown (KeyCode.L))
		{
			activeCam.selectCam2 ();
		}

		if (Input.GetKeyDown (KeyCode.M))
		{
			activeCam.selectCam3 ();
		}
	}

	private void loadWinScreen ()
	{
		SceneManager.LoadScene (3);  // you win screen
	}
}
