﻿using GMap.NET;
using GMap.NET.WindowsPresentation;
using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Device.Location;

namespace Lab3.Classes
{
    class Car : MapObject
    {
        PointLatLng point = new PointLatLng();

        public Car(string name, string type, PointLatLng Point) : base(name, type)
        {
            this.point = Point;
        }

        public override double getDistance(PointLatLng pointtwo)
        {
            GeoCoordinate geo1 = new GeoCoordinate(point.Lat, point.Lng);
            GeoCoordinate geo2 = new GeoCoordinate(pointtwo.Lat, pointtwo.Lng);
            return geo1.GetDistanceTo(geo2);
        }

        public override PointLatLng getFocus()
        {
            return point;
        }

        public override DateTime getCreationDate()
        {
            return creationTime;
        }

        public override GMapMarker GetMarker()
        {
            GMapMarker marker = new GMapMarker(point)
            {
                Shape = new Image
                {
                    Width = 32,
                    Height = 32,
                    ToolTip = "машина",
                    Source = new BitmapImage(new Uri("pack://application:,,,/Resources/car.png"))
                }
            };
            return marker;
        }

        public override string getTitle()
        {
            return objectName;
        }

        public override string getType()
        {
            return objectType;
        }
    }
}
