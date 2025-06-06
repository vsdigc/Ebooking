namespace AlgarveHotels
{
   public partial class HotelsPage : ContentPage
   {
      public HotelsPage(Zona zona)
      {
         InitializeComponent();
         BindingContext = zona;
         HotelsCollectionView.ItemsSource = zona.Hotels;
      }

      private void OnHotelSelected(object sender, SelectionChangedEventArgs e)
      {
         if (e.CurrentSelection.FirstOrDefault() is Hotel selectedHotel)
         {
            Navigation.PushAsync(new HotelDetailsPage(selectedHotel));
            ((CollectionView)sender).SelectedItem = null;
         }
      }
   }
}
