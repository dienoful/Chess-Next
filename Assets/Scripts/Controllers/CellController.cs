using Assets.Scripts.Models.Cells;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Controllers
{
    public class CellController : MonoBehaviour
    {
        private Cell _cell;
        public Cell Cell
        {
            get
            { 
                return _cell; 
            }
            set 
            {
                _cell = value;
            }
        }
    }
}