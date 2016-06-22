using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterObject
{
    public class CharStats : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (PropertyChanged != null) handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }

        private string _strength = "0";
        private string _dexterity = "0";
        private string _constitution = "0";
        private string _intelligence = "0";
        private string _wisdom = "0";
        private string _charisma = "0";

        public string Strength
        {
            get { return this._strength; }
            set
            {
                this._strength = value;
                NotifyPropertyChanged("Strength");
            }             
        }

        public string Dexterity
        {
            get { return this._dexterity; }
            set
            {
                this._dexterity = value;
                NotifyPropertyChanged("Dexterity");
            }
        }

        public string Constitution
        {
            get { return this._constitution; }
            set
            {
                this._dexterity = value;
                NotifyPropertyChanged("Constitution");
            }
        }

        public string Intelligence
        {
            get { return this._intelligence; }
            set
            {
                this._dexterity = value;
                NotifyPropertyChanged("Intelligence");
            }
        }

        public string Wisdom
        {
            get { return this._wisdom; }
            set
            {
                this._dexterity = value;
                NotifyPropertyChanged("Wisdom");
            }
        }

        public string Charisma
        {
            get { return this._charisma; }
            set
            {
                this._dexterity = value;
                NotifyPropertyChanged("Charisma");
            }
        }
    }
}
