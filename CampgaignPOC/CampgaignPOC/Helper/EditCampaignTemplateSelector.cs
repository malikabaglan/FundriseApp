using System;
using CampgaignPOC.Modal;
using Xamarin.Forms;

namespace CampgaignPOC.Helper
{
    public class EditCampaignTemplateSelector:DataTemplateSelector
    {
        public EditCampaignTemplateSelector() { }
        public DataTemplate TitleTemplate { get; set; }
        public DataTemplate GoalTemplate { get; set; }
        public DataTemplate CampaignTemplate { get; set; }
        public DataTemplate CategoryTemplate { get; set; }
        public DataTemplate LocationTemplate { get; set; }
        public DataTemplate SettingsTemplate { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var itemTemplate = item as EditCampaign;
            switch (itemTemplate.TemplateIndex)
            {
                case 0:
                    return TitleTemplate;
                case 1:
                    return GoalTemplate;
                case 2:
                    return CampaignTemplate;
                case 3:
                    return CategoryTemplate;
                case 4:
                    return LocationTemplate;
                default:
                    return SettingsTemplate;
            }
        }
    }
}
