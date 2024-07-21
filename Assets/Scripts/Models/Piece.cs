using Assets.Scripts.Models.Cells;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Models
{
    public class Piece
    {
        private Vector2Int _position;
        public Vector2Int Position
        {
            get => _position;
            set
            {
                _position = value;
                OnPositionChanged();
            }
        }

        public int Health { get; set; }

        public Piece(Vector2Int position, int health)
        {
            Position = position;
            Health = health;
        }

        protected virtual void OnPositionChanged()
        {

        }


        #region Actions
        public void Move(Cell targetCell)
        {

        }
        #endregion
    }
}