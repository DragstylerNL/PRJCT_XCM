using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableOB/TileRow", order = 1)]
public class TileZoneRow : ScriptableObject
{
    public TilePrefab[] TilePrefabs;
}
