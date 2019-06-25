using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CampgaignPOC.Modal;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CampgaignPOC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyCampgainsPage : TabbedPage
    {
        public MyCampgainsPage()
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
