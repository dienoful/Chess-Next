using Assets.Scripts.Models.Cells;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Models
{
    public class Field
    {
        private Cell[,] _cells;
        public Cell[,] Cells
        {
            get { return _cells; }
        }

        public int Width { get; private set; }
        public int Height { get; private set; }

        public Field(int width, int height)
        {
            Width = width;
            Height = height;
            _cells = new Cell[Width, Height];

            CreateCells(_cells);
        }

        public Cell GetCell(Vector2Int coordinates)
        {
            if (coordinates.x >= 0 && coordinates.x < Width && coordinates.y >= 0 && coordinates.y < Height)
            {
                return _cells[coordinates.x, coordinates.y];
            }
            return null;
        }
        public Cell GetCell(int x, int y)
        {
            if (x >= 0 && x < Width && y >= 0 && y < Height)
            {
                return _cells[x, y];
            }
            return null;
        }


        private void CreateCells(Cell[,] cells)
        {
            for (int x = 0; x < cells.GetLength(0); x++)
            {
                for (int y = 0; y < cells.GetLength(1); y++)
                {
                    cells[x, y] = new Cell(new Vector2Int(x, y), "default");
                }
            }
        }
    }
}
