namespace Pract8_2._0;

public partial class NewPage1 : ContentPage
{
    public NewPage1()
    {
        InitializeComponent();
        try
        {
            lister.ItemsSource = Cl.Pab1.ToList();
        }
        catch
        {

        }
    }

    private void lister_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var fam = sender as ListView;
        var famm = fam.SelectedItem as Class1;
        Class1 class1 = famm;
        MainPage.class11 = class1;  
    }
    private void Button_Clicked(object sender, EventArgs e)
    {
        lister.ItemsSource = Cl.Pab1.ToList();
    }
}