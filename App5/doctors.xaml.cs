using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Services.Maps;
using Windows.UI.Xaml.Controls.Maps;
using Windows.Devices.Geolocation;
using System.Diagnostics;
using System.Threading.Tasks;
using Windows.Storage.Streams;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App5
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class doctors : Page
    {
        // Used to recycle the map pin icon
        RandomAccessStreamReference mapIconStreamReference;
        RandomAccessStreamReference currentPositionStreamReference;



        public doctors()
        {
            this.InitializeComponent();

            mapIconStreamReference = RandomAccessStreamReference.CreateFromUri(new Uri("ms-appx:///Resources/mapIcons/doctorMapPinSMALL.png"));
            currentPositionStreamReference = RandomAccessStreamReference.CreateFromUri(new Uri("ms-appx:///Resources/mapIcons/userCurrentLocationSMALL.png"));




            addUserLocation();
            //string pharmacyCountString = ("pharmacy" +  pharmacyCount);
            addPharmacies(52.6664245, -8.553303400000004, "Lloyd's Pharmacy");
            //pharmacyCount += 1;
        }


        private void myMap_Loaded(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Map loaded successfully");
            Geopoint universityOfLimerickLoc = new Geopoint(new BasicGeoposition() { Latitude = 52.6735881, Longitude = -8.572437199999968 });
            myMap.Center = universityOfLimerickLoc;
            myMap.ZoomLevel = 12;
        }

        private void addUserLocation()
        {
            MapIcon userLocation = new MapIcon();
            userLocation.Location = new Geopoint(new BasicGeoposition { Latitude = 52.6735881, Longitude = -8.572437199999968 });
            userLocation.NormalizedAnchorPoint = new Point(0.5, 1.0);
            userLocation.Title = "Current Location";
            userLocation.Image = currentPositionStreamReference;
            userLocation.ZIndex = 0;
            myMap.MapElements.Add(userLocation);
        }

        /* List of map elements - may not be required, commented out for now
        public static List<MapElement> CreatePharmacyLocations()
        {
            return new List<MapElement>
            {
                new MapIcon { Location = new Geopoint(new BasicGeoposition { Latitude=52.6664245, Longitude=-8.553303400000004 }), Title= "Lloyd's Pharmacy" },
                new MapIcon { Location = new Geopoint(new BasicGeoposition { Latitude=52.6674095, Longitude=-8.570264899999984 }), Title= "Castletroy Pharmacy" },
                new MapIcon { Location = new Geopoint(new BasicGeoposition { Latitude=52.66759769999999, Longitude=-8.575392700000066 }), Title= "Castletroy Park Pharmacy" },
            };
        }
        */

        private void addPharmacies(double latitude, double longitude, string title)
        {
            /* Code to add the first pharmacies name and location data
            MapIcon mapIcon1 = new MapIcon();
            mapIcon1.Location = new Geopoint(new BasicGeoposition { Latitude = latitude, Longitude = longitude });
            mapIcon1.NormalizedAnchorPoint = new Point(0.5, 1.0);
            mapIcon1.Title = title;
            mapIcon1.Image = mapIconStreamReference;
            mapIcon1.ZIndex = 0;
            myMap.MapElements.Add(mapIcon1);
            */


            //Hardcoded map points - restore this comment if required
            MapIcon mapIcon1 = new MapIcon();
            mapIcon1.Location = new Geopoint(new BasicGeoposition { Latitude = 52.6664245, Longitude = -8.553303400000004 });
            mapIcon1.NormalizedAnchorPoint = new Point(0.5, 1.0);
            mapIcon1.Title = "Doctor 1";
            mapIcon1.Image = mapIconStreamReference;
            mapIcon1.ZIndex = 0;
            myMap.MapElements.Add(mapIcon1);

            MapIcon mapIcon2 = new MapIcon();
            mapIcon2.Location = new Geopoint(new BasicGeoposition { Latitude = 52.6674095, Longitude = -8.570264899999984 });
            mapIcon2.NormalizedAnchorPoint = new Point(0.5, 1.0);
            mapIcon2.Title = "Doctor 2";
            mapIcon2.Image = mapIconStreamReference;
            mapIcon2.ZIndex = 0;
            myMap.MapElements.Add(mapIcon2);

            MapIcon mapIcon3 = new MapIcon();
            mapIcon3.Location = new Geopoint(new BasicGeoposition { Latitude = 52.66759769999999, Longitude = -8.575392700000066 });
            mapIcon3.NormalizedAnchorPoint = new Point(0.5, 1.0);
            mapIcon3.Title = "Doctor 3";
            mapIcon3.Image = mapIconStreamReference;
            mapIcon3.ZIndex = 0;
            myMap.MapElements.Add(mapIcon3);
        }
    }
}