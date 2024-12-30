using UnityEngine;
public class RacingGame : MonoBehaviour
{
    public RaceState raceState = RaceState.None;
    void Update()
    {
        SimmulateRace();
    }
    public void SimmulateRace()
    {
        int raceStateValue = (int)raceState;
        switch (raceStateValue)
        {
            case 0: // None
                Debug.Log("No current race state.");
                break;
            case 1: // Start
                Debug.Log("Race has started!");
                break;
            case 2: // Turn
                Debug.Log("Making a turn!");
                break;
            case 3: // Crash
                Debug.Log("Crash occurred!");
                break;
            case 4: // Finish
                Debug.Log("Race finished!");
                break;
            default:
                Debug.Log("This state is not defined. Something is wrong!");
                break;
        }
    }
}
