namespace AlgarveHotels;

public partial class MainPage : ContentPage
{
   public MainPage()
   {
      InitializeComponent();
      LoadZonas();
   }

   private void LoadZonas()
   {
      var zonas = new List<Zona>
        {
            new Zona
            {
                Name = "Albufeira",
                ImageUrl = "albufeira_main.jpg",
                Description = "Praias e vida noturna em destaque.",
                Hotels = new List<Hotel>
                {
                    new Hotel
                    {
                        Name = "Hotel Sol e Mar",
                        ImageUrl = "hotelsolmar_01.jpg",
                        Description = "Vista para o mar e hotel calmo.",
                        AvePrice = 120,
                        Rating = 8.7,
                        BookingUrl = "https://encurtador.com.br/4CSn0"
                    },
                    new Hotel
                    {
                        Name = "INATEL",
                        ImageUrl = "inatel_hotel.jpg",
                        Description = "Praia logo em frente, ótimo pequeno-almoço e serviço de quarto.",
                        AvePrice = 173,
                        Rating = 8.1,
                        BookingUrl = "https://encurtador.com.br/mpuzu"
                    }
                }
            },
            new Zona
            {
                Name = "Lagos",
                ImageUrl = "lagos_cidade.png",
                Description = "Paisagens incríveis e história rica.",
                Hotels = new List<Hotel>
                {
                    new Hotel
                    {
                        Name = "Hotel Marina Rio",
                        ImageUrl = "marinario_porto.jpg",
                        Description = "Localizado perto da Marina e parque de estacionamento privado.",
                        AvePrice = 200,
                        Rating = 9.1,
                        BookingUrl = "https://encurtador.com.br/G18lh"
                    }
                }
            }
        };

      ZonasCollectionView.ItemsSource = zonas;
   }

   private async void ZonasCollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
   {
      if (e.CurrentSelection.FirstOrDefault() is Zona selectedZona)
      {
         await Navigation.PushAsync(new HotelsPage(selectedZona));
         ZonasCollectionView.SelectedItem = null;
      }
   }
}

public class Zona
{
   public required string Name { get; set; }
   public required string ImageUrl { get; set; }
   public required string Description { get; set; }
   public List<Hotel> Hotels { get; set; } = new();
}

public class Hotel
{
   public required string Name { get; set; }
   public required string ImageUrl { get; set; }
   public required string Description { get; set; }
   public required double AvePrice { get; set; }
   public required double Rating { get; set; }
   public required string BookingUrl { get; set; }
   public bool Favorite { get; set; } = false;
}

