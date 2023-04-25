using System.Collections.ObjectModel;

namespace Maui_IssueScrollToAsync;

public partial class MainPage : ContentPage
{
    public ObservableCollection<ViewModelTest> pVmTest = new ObservableCollection<ViewModelTest>();

    public MainPage()
    {
        InitializeComponent();

        for (int i = 0; i < 100; i++)
        {
            pVmTest.Add(new ViewModelTest() { No = i + 1 });
        }
        BindableLayout.SetItemsSource(slTest, pVmTest);
    }

    private void btnTop_Clicked(object sender, EventArgs e)
    {
        svTest.ScrollToAsync(0, 0, false);
    }

    private void btnStart_Clicked(object sender, EventArgs e)
    {
        Grid view = slTest.Children.ElementAt(49) as Grid;
        svTest.ScrollToAsync(view, ScrollToPosition.Start, false);
    }

    private void btnCenter_Clicked(object sender, EventArgs e)
    {
        Grid view = slTest.Children.ElementAt(49) as Grid;
        svTest.ScrollToAsync(view, ScrollToPosition.Center, false);
    }

    private void btnEnd_Clicked(object sender, EventArgs e)
    {
        Grid view = slTest.Children.ElementAt(49) as Grid;
        svTest.ScrollToAsync(view, ScrollToPosition.End, false);
    }

    private void btnMakeVisible_Clicked(object sender, EventArgs e)
    {
        Grid view = slTest.Children.ElementAt(49) as Grid;
        svTest.ScrollToAsync(view, ScrollToPosition.MakeVisible, false);
    }

}

public class ViewModelTest
{
    public int No { get; set; }

    public string ItemName { get; set; }
}