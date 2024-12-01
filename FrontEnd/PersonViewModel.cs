using DataLayer;
using Microsoft.AspNetCore.Components;
using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace FrontEnd
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;
        private DateOnly? _dateOfBirth;
        private string? _personalIdNumber;
        private string _email;
        private Country _countryOfOrigin;
        private Gender _gender;
        private bool _skipPersonalId;

        public bool SkipPersonalId
        {
            get => _skipPersonalId;
            set
            {
                _skipPersonalId = value;
                if (_skipPersonalId)
                {
                    PersonalIdNumber = null;
                }
            }
        }


        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                OnPropertyChanged();
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                OnPropertyChanged();
            }
        }
        public DateOnly? DateOfBirth
        {
            get => _dateOfBirth;
            set
            {
                _dateOfBirth = value;
                OnPropertyChanged();
            }
        }
        public string? PersonalIdNumber
        {
            get => _personalIdNumber;
            set
            {
                _personalIdNumber = value;
                OnPropertyChanged();
            }
        }
        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }
        public Country CountryOfOrigin
        {
            get => _countryOfOrigin;
            set
            {
                _countryOfOrigin = value;
                OnPropertyChanged();
            }
        }
        public Gender Gender
        {
            get => _gender;
            set
            {
                _gender = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;



        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
