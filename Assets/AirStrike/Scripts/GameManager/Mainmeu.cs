using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Mainmeu : MonoBehaviour
{

    public GUISkin skin;
    public Texture2D Logo;
    private int Mode = 0;
    void Start()
    {

    }

    void Update()
    {

    }

    public void OnGUI()
    {
        if (skin)
            GUI.skin = skin;

        switch (Mode)
        {
            //GUI.DrawTexture(new Rect(Screen.width/2 - Logo.width/2 , Screen.height/2 - 150,Logo.width,Logo.height),Logo);

            case 0:
                if (GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height / 2, 300, 40), "Classic"))
                {
                    //Application.LoadLevel("Classic");
                    SceneManager.LoadScene("Classic");
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height / 2 + 50, 300, 40), "Modern"))
                {
                    //Application.LoadLevel("Modern");
                    SceneManager.LoadScene("Modern");
                }
                //if(GUI.Button(new Rect(Screen.width/2 - 150,Screen.height/2 + 100,300,40),"Invasion")){
                //	//Application.LoadLevel("Invasion");
                //	SceneManager.LoadScene("Invasion");
                //}
                if (GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height / 2 + 100, 300, 40), "Options"))
                {
                    //Application.LoadLevel("Invasion");
                    Mode = 1;
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height / 2 + 150, 300, 40), "Exit"))
                {
                    Application.Quit();
                }

                GUI.skin.label.alignment = TextAnchor.MiddleCenter;
                //GUI.Label(new Rect(0,Screen.height-90,Screen.width,50),"Air strike starter kit. by Rachan Neamprasert\n www.hardworkerstudio.com");
                break;
            case 1:
                GUI.skin.label.alignment = TextAnchor.MiddleCenter;
                GUI.Label(new Rect(0, Screen.height / 2 + 10, Screen.width, 30), "Options");

                //GUI.DrawTexture(new Rect(Screen.width / 2 - Logo.width / 2, Screen.height / 2 - 150, Logo.width, Logo.height), Logo);
                if (GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height / 2 + 50, 300, 40), "Gyroscope " + GameManager.Acceleration))
                {
                    GameManager.Acceleration = !GameManager.Acceleration;
                }

                if (GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height / 2 + 100, 300, 40), "Simple Control " + GameManager.SimpleControl))
                {
                    GameManager.SimpleControl = !GameManager.SimpleControl;
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height / 2 + 150, 300, 40), "Return"))
                {
                    Time.timeScale = 1;
                    Mode = 0;
                }
                break;
        }
    }
}
