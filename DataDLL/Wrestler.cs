using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDLL
{
    public class WrestlerType
    {
        #region Class Enums

        /// <summary>
        /// Denotes a Wrestler's Gender...just don't assume
        /// </summary>
        public enum Genders
        {
            Male = 0,
            Female = 1,
            Other = 2
        }

        /// <summary>
        /// Denotes a Wrestler's Position within the company
        /// </summary>
        public enum Positions
        {
            Jobber = 0,
            Opener = 1,
            Midcard = 2,
            UpperMidcard = 3,
            MainEvent = 4
        }

        /// <summary>
        /// Denotes a Wrestler's Disposition towards the crowd
        /// </summary>
        public enum Dispositions
        {
            Face = 0,
            Tweener = 1,
            Hell = 2
        }

        /// <summary>
        /// Regions where workers originate
        /// </summary>
        public enum Regions
        {
            SouthEast = 0,
            NorthEast = 1,
            MidWest = 2,
            SouthWest = 3,
            NorthWest = 4,
            EastCanada = 5,
            CentralCanada = 6,
            WesternCanada = 7,
            NorthMexico = 8,
            SouthMexico = 9
        }
        #endregion

        private string _realName;
        private string _wrestlerName;
        private Genders _gender;
        private Positions _position;
        private Dispositions _dispostion;
        private string _homeTown;
        private Regions _region;

        /// <summary>
        /// The wrestler's real name
        /// </summary>
        public string RealName
        {
            get { return _realName; }
            set
            {
                _realName = value;
            }
        }

        /// <summary>
        /// The wrestler's work name
        /// </summary>
        public string Wrestlername
        {
            get { return _wrestlerName; }
            set
            {
                _wrestlerName = value;
            }
        }

        /// <summary>
        /// A wrestler's gender
        /// </summary>
        public Genders Gender
        {
            get { return _gender; }
            set
            {
                _gender = value;
            }
        }

        /// <summary>
        /// A wrestler's position within the company
        /// </summary>
        public Positions Position
        {
            get { return _position; }
            set
            {
                _position = value;
            }
        }

        /// <summary>
        /// A wrestler's dispostion towards the crowd
        /// </summary>
        public Dispositions Disposition
        {
            get { return _dispostion; }
            set
            {
                _dispostion = value;
            }
        }

        /// <summary>
        /// A wrestler's hometown
        /// </summary>
        public string HomeTown
        {
            get { return _homeTown; }
            set
            {
                _homeTown = value;
            }
        }

        public Regions Region
        {
            get { return _region; }
            set
            {
                _region = value;
            }
        }
    }

    public class WrestlerData
    {

    }
}
