using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame.S2.Models
{
    public class Location
    {
        #region FIELDS
        private int _id;
        private string _name;
        private string _description;
        private bool _accessible;
        private int _modifyExperiencePoints;
        private int _modifyHealth;


        #endregion

        #region PROPERTIES
        public int ModifyHealth
        {
            get { return _modifyHealth; }
            set { _modifyHealth = value; }
        }


        public int ModifyExperiencePoints
        {
            get { return _modifyExperiencePoints; }
            set { _modifyExperiencePoints = value; }
        }


        public bool Accessible
        {
            get { return _accessible; }
            set { _accessible = value; }
        }


        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }



        #endregion

        #region CONSTRUCTORS


        #endregion

        #region METHODS


        #endregion
    }
}
