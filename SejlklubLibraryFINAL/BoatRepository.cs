using System;
using System.Collections.Generic;
using System.Text;

namespace SejlklubLibraryFINAL
{
    public class BoatRepository
    {
        #region InstanceField
        private List<Boat> _boats;
        #endregion

        #region Constructor
        public BoatRepository()
        {
            _boats = new List<Boat>();
        }
        #endregion

        #region Methods
        public void AddBoat(Boat boat)
        {
            _boats.Add(boat);
        }

        public void RemoveBoat(Boat boat)
        {
            _boats.Remove(boat);
        }
        public Boat GetBoatById(Guid id)
        {
            return _boats.Find(boat => boat.Id == id);
        }
        public List<Boat> GetAllBoats()
        {
            return _boats;
        }
        #endregion
    }
}

