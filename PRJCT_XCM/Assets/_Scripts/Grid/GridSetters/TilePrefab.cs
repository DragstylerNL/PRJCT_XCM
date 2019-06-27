using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableOB/TilePrefab", order = 1)]
public class TilePrefab: ScriptableObject
{
    public TileStates.TileEffect tileEffect = TileStates.TileEffect.None;

    public GameObject gridBase;
    public GameObject[] northernObjects;
    public TileStates.coverType northernCover = TileStates.coverType.None;
    public GameObject[] easternObjects;
    public TileStates.coverType easternCover = TileStates.coverType.None;
    public GameObject[] southernObjects;
    public TileStates.coverType southernCover = TileStates.coverType.None;
    public GameObject[] westernObjects;
    public TileStates.coverType westernCover = TileStates.coverType.None;
}
