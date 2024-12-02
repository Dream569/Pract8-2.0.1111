namespace Pract8_2._0
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Cl.Pab1 = new List<Class1>();
        }
        public static Class1 class11 { get; set; }
        public void Otobraz(object sender, EventArgs e)
        {
            FIO1.Text = class11.Fam;
            FIO2.Text = class11.Nam;
            FIO3.Text = class11.LasNam;
            Gender.SelectedItem = class11.Gend;
            Age.Text = class11.Age;
            Tel.Text = class11.Tel;
            Photo.Source = class11.PhotoPath.Replace("File: ", "");
        }
        private void SaweClick(object sender, EventArgs e)
        {
            Class1 class1 = new Class1();
            class1.Fam = FIO1.Text;
            class1.Nam = FIO2.Text;
            if (Photo.Source != null)
            {
                class1.PhotoPath = Photo.Source.ToString();
            }
            else DisplayAlert("Внимание", "Где фото?", "Ок");
            class1.LasNam = FIO3.Text;
            class1.Gend = Gender.SelectedItem?.ToString();
            class1.Age = Age.Text;
            class1.Tel = Tel.Text;
            Cl.Pab1.Add(class1);
            StatusLabel.Text = "Данные сохранены!";
        }

        private async void AddPhotoClick(object sender, EventArgs e)
        {
            var result = await MediaPicker.PickPhotoAsync();
            if (result != null)
            {
               Photo.Source = result.FullPath;
            }
        }
    }

}
