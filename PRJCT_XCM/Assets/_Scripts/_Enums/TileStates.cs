using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileStates : MonoBehaviour
{
    public enum VisabilityLevel
    {
        Hidden,
        Blurred,
        Visable
    }

    public enum TileOccupiedState
    {
        Taken,
        Available
    }

    public enum TileEffect
    {
        None
    }

    public enum coverType
    {
        None,
        Half,
        Full
    }
}
