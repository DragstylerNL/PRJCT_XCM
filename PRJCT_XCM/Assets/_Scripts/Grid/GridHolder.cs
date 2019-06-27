using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridHolder : MonoBehaviour
{

    private GameObject[,] MainGrid;
    private Vector2 TileOffsetSize { get; } = new Vector3(1.1f, 1.1f);
    
    /// <summary>
    /// Set the Size of the playingField
    /// </summary>
    /// <param name="_MainGridSize">desired size</param>
    public void SetMainGridSize(Vector2 _MainGridSize)
    {
        MainGrid = new GameObject[(int)_MainGridSize.x, (int)_MainGridSize.y];
    }

    /// <summary>
    /// Set a single piece of the grid
    /// </summary>
    /// <param name="_aGridPiece">This should be the desired piece to be placed</param>
    /// <param name="_GPos">This is Where in the Maingrid you want to put this piece at</param>
    public void SetGridPiece(GameObject _aGridPiece, Vector2 _GPos)
    {
        MainGrid[(int)_GPos.x, (int)_GPos.y] = _aGridPiece;
        MainGrid[(int)_GPos.x, (int)_GPos.y].GetComponent<GridTile>().SetGridPos(new Vector2(_GPos.x, _GPos.y), TileOffsetSize);
    }

    /// <summary>
    /// Set a Zone of pieces, handy after the random Gen has been made
    /// </summary>
    /// <param name="_theGridPieces">An array filled with the objects that need to be put in the grid for savekeeping</param>
    /// <param name="_GposOffsetFrom0">The offset at which the pieces should be placed</param>
    public void SetZoneGridPieces(GameObject[,] _theGridPieces, Vector3 _GposOffsetFrom0)
    {
        for(int x = (int)_GposOffsetFrom0.x; x < _theGridPieces.GetLength(0); x++)
        {
            for (int y = (int)_GposOffsetFrom0.y; y < _theGridPieces.GetLength(1); y++)
            {
                MainGrid[x, y] = _theGridPieces[x - (int)_GposOffsetFrom0.x, y - (int)_GposOffsetFrom0.y];
                MainGrid[x, y].GetComponent<GridTile>().SetGridPos(new Vector2(x, y), TileOffsetSize);
            }
        }
    }

}
