using System;
using Microsoft.Maui.Controls;

namespace AlgarveHotels
{
   public partial class HotelDetailsPage : ContentPage
   {
      private Hotel _hotel;

      public HotelDetailsPage(Hotel hotel)
      {
         InitializeComponent();
         _hotel = hotel;
         BindingContext = _hotel;
      }

      private async void OnBookingClicked(object sender, EventArgs e)
      {
         if (!string.IsNullOrWhiteSpace(_hotel.BookingUrl))
         {
            await Launcher.Default.OpenAsync(_hotel.BookingUrl);
         }
      }
   }
}
