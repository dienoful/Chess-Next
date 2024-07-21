using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Models.Cells
{
    public class SquareCell : Cell
    {
        public SquareCell(Vector2Int coordinates, string terrainType) 
            : base(coordinates, terrainType)
        {

        }
    }
}