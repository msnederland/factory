using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    // Reference robot part game objects
    public Transform joint0;
    public Transform joint1;
    public Transform joint2;
    public Transform joint3;
    public Transform joint4;
    public Transform joint5;

    // Joint ranges
    private float joint0Range = 720;
    private float joint1Range = 720;
    private float joint2Range = 720;
    private float joint3Range = 720;
    private float joint4Range = 720;
    private float joint5Range = 999999;


    // Declare turn rates
    private float joint0TurnRate = 0.2f;
    private float joint1TurnRate = 0.2f;
    private float joint2TurnRate = 0.2f;
    private float joint3TurnRate = 0.2f;
    private float joint4TurnRate = 0.2f;
    private float joint5TurnRate = 0.2f;

    // Declare slider variables
    public float joint0SliderValue = 0.0f;
    public float joint1SliderValue = 0.0f;
    public float joint2SliderValue = 0.0f;
    public float joint3SliderValue = 0.0f;
    public float joint4SliderValue = 0.0f;
    public float joint5SliderValue = 0.0f;

    private int[] jointList;

    // Start is called before the first frame update
    void Start()
    {
        joint0.Rotate(0, 0, 120, Space.Self);
    }

    // Update is called once per frame
    void Update()
    {
        // joint0.Rotate(0, 0, joint0SliderValue * joint0TurnRate);
        // joint1.Rotate(0, 0, joint1SliderValue * joint1TurnRate);
        // joint2.Rotate(0, 0, joint2SliderValue * joint2TurnRate);
        // joint3.Rotate(0, 0, joint3SliderValue * joint3TurnRate);
        // joint4.Rotate(0, 0, joint4SliderValue * joint4TurnRate);
        // joint5.Rotate(0, 0, joint5SliderValue * joint5TurnRate);

        // checkMouseUp();

        // joint0.Rotate(0, 0, 1, Space.Self);
        
    }

    void OnGUI()
    {
        joint0SliderValue = GUI.HorizontalSlider(new Rect(25, 25, 100, 30), joint0SliderValue, -10.0f, 10.0f);
        joint1SliderValue = GUI.HorizontalSlider(new Rect(25, 80, 100, 30), joint1SliderValue, -10.0f, 10.0f);
        joint2SliderValue = GUI.HorizontalSlider(new Rect(25, 135, 100, 30), joint2SliderValue, -10.0f, 10.0f);
        joint3SliderValue = GUI.HorizontalSlider(new Rect(25, 190, 100, 30), joint3SliderValue, -10.0f, 10.0f);
        joint4SliderValue = GUI.HorizontalSlider(new Rect(25, 245, 100, 30), joint4SliderValue, -10.0f, 10.0f);
        joint5SliderValue = GUI.HorizontalSlider(new Rect(25, 300, 100, 30), joint5SliderValue, -10.0f, 10.0f);
    }

    void checkMouseUp()
    {
        if(Input.GetMouseButtonUp(0))
        {
            joint0SliderValue = 0;
            joint1SliderValue = 0;
            joint2SliderValue = 0;
            joint3SliderValue = 0;
            joint4SliderValue = 0;
            joint5SliderValue = 0;
        }
    }

}
