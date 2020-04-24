﻿using GMap.NET;
using GMap.NET.WindowsPresentation;
using System;
using System.Windows.Shapes;
using System.Collections.Generic;
using System.Windows.Media.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Device.Location;

namespace Lab3.Classes
{
    class Area : MapObject
    {
        PointLatLng point = new PointLatLng();
        List<PointLatLng> points = new List<PointLatLng>();

      public Area(string name, string type, List<PointLatLng> Points, PointLatLng Point) : base(name,type)
      {
            point = Point;
            points = Points;
      }
       public override string getTitle()
       {
            return objectName;
       }
       public override double getDistance(PointLatLng pointtwo)
       {
            GeoCoordinate geo1 = new GeoCoordinate(pointtwo.Lat, pointtwo.Lng);
            GeoCoordinate geo2 = new GeoCoordinate(point.Lat, point.Lng);
            double distance = geo1.GetDistanceTo(geo2);
            for (int i = 0; i < points.Count; i++)
            {
                geo2 = new GeoCoordinate(points[i].Lat, points[i].Lng);
                if (geo1.GetDistanceTo(geo2) < distance)
                    distance = geo1.GetDistanceTo(geo2);
            }
            return distance;
        }

       public override PointLatLng getFocus()
       {
            return point;
       }
       public override GMapMarker GetMarker()
       {
            GMapMarker marker = new GMapPolygon(points)
            {
                Shape = new Path
                {
                    Stroke = Brushes.Black,
                    Fill = Brushes.Green,
                    Opacity = 0.5
                }
            };

            return marker;
       }
       public override DateTime getCreationDate()
       {
            return creationTime;
       }

        public override string getType()
        {
            return objectType;
        }
    }
}
