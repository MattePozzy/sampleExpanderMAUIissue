using MauiReactor;

namespace Project2.Pages
{
    [Scaffold(typeof(CommunityToolkit.Maui.Views.Expander))]
    public partial class VolosExpander { }

    internal class MainPageState
    {
        public int Counter { get; set; }
    }

    internal class MainPage : Component<MainPageState>
    {
        public override VisualNode Render()
        {
            Button btnHeader = new Button()
                .Text("H")
                //.ImageSource(new MauiControls.FontImageSource()
                //{
                //    FontAutoScalingEnabled = true,
                //    FontFamily = Costanti.Font.MaterialDesignIcons.ToString(),
                //    Glyph = MaterialFontIcons.Plus
                //})
                .BackgroundColor(Colors.Green).CornerRadius(80)
                .HorizontalOptions(MauiControls.LayoutOptions.End)
                .VerticalOptions(MauiControls.LayoutOptions.End);

            Button btnContent1 = new Button()
                .Text("C1")
                //.ImageSource(new MauiControls.FontImageSource()
                //{
                //    FontAutoScalingEnabled = true,
                //    FontFamily = Costanti.Font.MaterialDesignIcons.ToString(),
                //    Glyph = MaterialFontIcons.Plus
                //})
                .BackgroundColor(Colors.Red).CornerRadius(80)
                .HorizontalOptions(MauiControls.LayoutOptions.End)
                .VerticalOptions(MauiControls.LayoutOptions.End);

            Button btnContent2 = new Button()
                .Text("C2")
                //.ImageSource(new MauiControls.FontImageSource()
                //{
                //    FontAutoScalingEnabled = true,
                //    FontFamily = Costanti.Font.MaterialDesignIcons.ToString(),
                //    Glyph = MaterialFontIcons.Plus
                //})
                .BackgroundColor(Colors.Blue).CornerRadius(80)
                .HorizontalOptions(MauiControls.LayoutOptions.End)
                .VerticalOptions(MauiControls.LayoutOptions.End);

            return new ContentPage
            {
                new VolosExpander()
                {
                    new VStack()
                    {
                        btnContent1,
                        btnContent2,
                    }.Spacing(20)
                }
                .Header(TemplateHost.Create(btnHeader).NativeElement as MauiControls.Button)
                .VCenter().HCenter()
            };
        }
    }
}