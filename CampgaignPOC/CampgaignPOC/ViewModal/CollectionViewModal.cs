using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CampgaignPOC.Modal;

namespace CampgaignPOC.ViewModal
{
    public class CollectionViewModal: INotifyPropertyChanged
    {
        public ObservableCollection<People> Peoples { get; private set; }         readonly IList<People> source;          public CollectionViewModal()         {             source = new List<People>();             CreateMonkeyCollection();         }          void CreateMonkeyCollection()         {             source.Add(new People             {                 Name = "Baboon",                 ImageUrl = "Xamarinlogo.png"             });              source.Add(new People             {                 Name = "Capuchin Monkey",                 ImageUrl = "Xamarinlogo.png"             });              source.Add(new People             {                 Name = "Blue Monkey",                 ImageUrl = "Xamarinlogo.png"             });              source.Add(new People             {                 Name = "Baboon",                 ImageUrl = "Xamarinlogo.png"             });              source.Add(new People             {                 Name = "Capuchin Monkey",                 ImageUrl = "Xamarinlogo.png"             });              source.Add(new People             {                 Name = "Blue Monkey",                 ImageUrl = "Xamarinlogo.png"             });              source.Add(new People             {                 Name = "Baboon",                 ImageUrl = "Xamarinlogo.png"             });              source.Add(new People             {                 Name = "Capuchin Monkey",                 ImageUrl = "xamLogo.png"             });              //source.Add(new People             //{             //    Name = "Blue Monkey",             //    ImageUrl = "Xamarinlogo.png"             //});              //source.Add(new People             //{             //    Name = "Baboon",             //    ImageUrl = "xamLogo.png"             //});              //source.Add(new People             //{             //    Name = "Capuchin Monkey",             //    ImageUrl = "Xamarinlogo.png"             //});              //source.Add(new People             //{             //    Name = "Blue Monkey",             //    ImageUrl = "Xamarinlogo.png"             //});              Peoples = new ObservableCollection<People>(source);         }

        #region INotifyPropertyChanged         public event PropertyChangedEventHandler PropertyChanged;          void OnPropertyChanged([CallerMemberName] string propertyName = null)         {             PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));         }
        #endregion     } }  