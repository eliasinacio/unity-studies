using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int weekDay;
    public int[] weekDays = { 1, 2, 3, 4, 5, 6, 7 }; // Array

    public List<int> ages = new List<int>();

    public List<string> names = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        // Switch
        switch (weekDay)
        {
            case 1:
                {
                    Debug.Log("Monday");
                    break;
                }

            case 2:
                {
                    Debug.Log("Tuesday");
                    break;
                }

            case 3:
                {
                    Debug.Log("Wednesday");
                    break;
                }

            case 4:
                {
                    Debug.Log("Thursday");
                    break;
                }

            case 5:
                {
                    Debug.Log("Friday");
                    break;
                }

            case 6:
                {
                    Debug.Log("Saturday");
                    break;
                }

            case 7:
                {
                    Debug.Log("Sunday");
                    break;
                }

            default:
                {
                    Debug.Log("Invalid day");
                    break;
                }
        }

        // For
        for (int i = 0; i < 10; i++)
        {
            Debug.Log("iterator: " + i);
        }

        // Foreach
        foreach (int i in weekDays)
        {
            Debug.Log(">> weekDay :" + i);
        }

        // Adding items to List
        ages.Add(5);
        ages.Add(54);
        ages.Add(20);
        ages.Add(8);

        // Remove specific item from List
        ages.Remove(20);

        // Clear List
        ages.Clear();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(">> Hello world");
        }
    }
}
