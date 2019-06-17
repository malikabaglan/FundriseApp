using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CampgaignPOC.Modal;
using CampgaignPOC.ViewModal;
using Xamarin.Forms;

namespace CampgaignPOC
{
    public partial class CollectionView : ContentPage
    {
       
        public CollectionView()
        {
            InitializeComponent();
            BindingContext = new CollectionViewModal();

        }
    }
}
