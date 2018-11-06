using System;
using System.Collections.Generic;
using System.Text;
using Realms;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CocktailsM.Views;
using CocktailsM.Models;
using System.Linq;
using Xamarin.Forms;

namespace CocktailsM.ViewModels
{
    public class Login : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private List<User> _listOfUserDetails;
        private Realm _getRealmInstance = Realm.GetInstance();
        private User _user = new User();

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        

        public List<User> ListOfUserDetails
        {
            get { return _listOfUserDetails; }
            set
            {
                _listOfUserDetails = value;
                OnPropertyChanged(); // Added the OnPropertyChanged Method
            }
        }

        public User user
        {
            get { return _user; }
            set
            {
                _user= value;
                OnPropertyChanged(); // Add the OnPropertyChanged();
            }
        }
        public Login()
        {
            ListOfUserDetails = _getRealmInstance.All<User>().ToList();
        }
        public Command CreateCommand // for ADD
        {
            get
            {
                return new Command(() =>
                {
                    _getRealmInstance.Write(() =>
                    {
                        _getRealmInstance.Add(_user); // Add the whole set of details
                    });
                });
            }
        }
        public Command LoginCommand // for ADD
        {
            get
            {
                return new Command(() =>
                {
                    LoginFunc();
                });
            }
        }

        private void LoginFunc()
        {
           User activeUser =  ListOfUserDetails.Where(x => x.UserName.ToString() = "");
        }
    }
}
