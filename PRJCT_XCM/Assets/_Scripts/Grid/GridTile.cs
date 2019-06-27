// also looked into srp (seperation of consern)(render from code)
using System.Collections.Generic;
using UnityEngine;

public class GridTile : MonoBehaviour
{
    // PieceInformation
    private Vector2 pos = Vector2.zero;
    private TileStates.VisabilityLevel visabilityLevel { get; set; } = TileStates.VisabilityLevel.Hidden;
    private TileStates.TileOccupiedState tileOccupiedState { get; set; } = TileStates.TileOccupiedState.Available;
    private TileStates.TileEffect tileEffect { get; set; } = TileStates.TileEffect.None;
    private Dictionary<Directions.Dir, TileStates.coverType> tileCover { get; set; }

    // Positions
    public void SetGridPos(Vector2 _desPos, Vector2 _TileOffsetSize)
    {
        pos = _desPos;
        SetWorldPos(_TileOffsetSize);
    }
    public Vector3 GetGridPos()
    {
        return pos;
    }
    public void SetWorldPos(Vector2 _TileOffsetSize)
    {
        transform.position = new Vector3(pos.x * _TileOffsetSize.x, pos.y * _TileOffsetSize.y);
    }
    public Vector3 GetWorldPos()
    {
        return transform.position;
    }
    
    
}
