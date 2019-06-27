using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableOB/GridPiece", order = 1)]
public class GridPieceSetter : ScriptableObject
{
    public TileStates.VisabilityLevel visabilityLevel { get; set; }
    public TileStates.TileOccupiedState tileOccupiedState { get; set; }
    public TileStates.TileEffect tileEffect { get; set; }

    public GameObject gridBase;
    public GameObject[] coverN_E_S_W;
}
