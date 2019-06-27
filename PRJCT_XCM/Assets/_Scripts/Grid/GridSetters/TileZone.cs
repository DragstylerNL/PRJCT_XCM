using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableOB/TileZone", order = 1)]
public class TileZone : ScriptableObject
{
    public TileZoneRow[] TilePrefabs;
}
