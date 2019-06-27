// also looked into srp (seperation of consern)(render from code)
using System.Collections.Generic;
using UnityEngine;

public class GridPiece : MonoBehaviour
{
    // PieceInformation
    private Vector3 pos = Vector3.zero;
    private TileStates.VisabilityLevel visabilityLevel { get; set; }
    private TileStates.TileOccupiedState tileOccupiedState { get; set; }
    private TileStates.TileEffect tileEffect { get; set; }
    private Dictionary<Directions.Dir, TileStates.coverType> tileCover;

    // RenderStuff


    void Start()
    {
        // TileStates
        visabilityLevel = TileStates.VisabilityLevel.Hidden;
        tileOccupiedState = TileStates.TileOccupiedState.Available;
        tileEffect = TileStates.TileEffect.None;

        // Rendering
    }

    // Positions
    public void SetGridPos(Vector3 _desPos)
    {
        pos = _desPos;
    }
    public Vector3 GetGridPos()
    {
        return pos;
    }
    public Vector3 GetWorldPos()
    {
        return transform.position;
    }
    
}
