using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Models.Cells
{
    public class Cell
    {
        private Vector2Int _coordinates;
        public Vector2Int Coordinates
        {
            get => _coordinates;
            set
            {
                _coordinates = value;
                OnCoordinatesChanged();
            }
        }
        public string TerrainType { get; set; }
        public bool IsOccupied { get; set; }

        public Cell(Vector2Int coordinates, string terrainType)
        {
            Coordinates = coordinates;
            TerrainType = terrainType;
        }

        protected virtual void OnCoordinatesChanged()
        {

        }
    }
}
