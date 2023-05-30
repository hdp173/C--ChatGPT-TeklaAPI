using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPT
{
    internal static class Examples
    {
        public static List<string> questions = new List<string>() {
            "Create e viewmodel for me with the name GeneralControlViewModel, with the properties General and BalconyModel and a activator called Activate_VeboBalconyV2_GeneralControl",
            "Also, create the xaml file."
        };

        public static List<string> answers = new List<string>()
        {
            @"
            ```
            public class GeneralControlViewModel : WindowViewModel
            {
                private ViewModelSetup _input;

                public ViewModelSetup Input
                {
                    get => _input;
                    set => SetValue(ref _input, value);
                }

                private General _balconyModel;
                public General BalconyModel
                {
                    get => _balconyModel;
                    set => SetValue(ref _balconyModel, value);
                }

                [PublisehdMethod]
                public void Activate_VeboBalconyV2_GeneralControl(ViewModelSetup input)
                {
                    try
                    {
                        if (input != null)
                        {

                        }
                        else
                        {
                            input = null;
                        }
                    } catch (Exception ex)
                    {
                        this.LogError($""Error in {nameof(Activate_VeboBalconyV2_GeneralControl)} in {nameof(GeneralControlViewModel)}"", e);
                    }
                }
            }
            ```
            ",
            @"
            ```
            <UserControl x:Class=""VeboBalconyPanel.SubControls.GeneralControls.GeneralControl""
                        xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation""
                        xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml""
                        d:DataContext=""{d:DesignInstance Type=local:GeneralControlViewModel, IsDesignTimeCreatable=False}""
                        mc:Ignorable=""d""
                        d:DesignHeight=""950"" d:DesignWidth=""800"">
                <UserControl.Resources>
                    <converters:GalesToVisibilityConverter x:Key=""GalesToVisibilityConverter"" />
                    <converters:FreeToVisibilityConverter x:Key=""FreeToVisibilityConverter"" />
                    <converters:ProfileToVisibilityConverter x:Key=""ProfileToVisibilityConvert"" />
                </UserControl.Resources>
            </UserControl>
            ```
            "
        };
    }
}
