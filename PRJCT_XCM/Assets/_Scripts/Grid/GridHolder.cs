using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridHolder : MonoBehaviour
{

    private GameObject[,,] MainGrid;
    
    /// <summary>
    /// Set a single piece of the grid
    /// </summary>
    /// <param name="_aGridPiece">This should be the desired piece to be placed</param>
    /// <param name="_GPos">This is Where in the Maingrid you want to put this piece at</param>
    public void SetGridPiece(GameObject _aGridPiece, Vector3 _GPos)
    {
        MainGrid[(int)_GPos.x, (int)_GPos.y, (int)_GPos.z] = _aGridPiece;
    }

    /// <summary>
    /// Set a Zone of pieces, handy after the random Gen has been made
    /// </summary>
    /// <param name="_theGridPieces">An array filled with the objects that need to be put in the grid for savekeeping</param>
    /// <param name="_GposOffsetFrom0">The offset at which the pieces should be placed</param>
    public void SetZoneGridPieces(GameObject[,,] _theGridPieces, Vector3 _GposOffsetFrom0)
    {
        for(int x = (int)_GposOffsetFrom0.x; x < _theGridPieces.GetLength(0); x++)
        {
            for (int y = (int)_GposOffsetFrom0.y; y < _theGridPieces.GetLength(1); y++)
            {
                for (int z = (int)_GposOffsetFrom0.z; z < _theGridPieces.GetLength(2); z++)
                {
                    MainGrid[x, y, z] = _theGridPieces[x - (int)_GposOffsetFrom0.x, y - (int)_GposOffsetFrom0.y, (int)_GposOffsetFrom0.z];
                }
            }
        }
    }

    public void Start()
    {
        
    }
}
