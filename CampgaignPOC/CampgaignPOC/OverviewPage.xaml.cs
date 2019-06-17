using System;
using System.Collections.Generic;
using CampgaignPOC.Modal;
using Xamarin.Forms;

namespace CampgaignPOC
{
    public partial class OverviewPage : ContentPage
    {
        public OverviewPage()
        {
            InitializeComponent();
            var EditCampaignData = new List<EditCampaign>
            {
                new EditCampaign { TemplateIndex = 0 },
                new EditCampaign { TemplateIndex = 1 },
                new EditCampaign { TemplateIndex = 2 },
                new EditCampaign { TemplateIndex = 3 },
                new EditCampaign { TemplateIndex = 4 },
                new EditCampaign { TemplateIndex = 5 }
            };

            EditCampaignList.ItemsSource = EditCampaignData;
        }
    }
}
