using System.Collections.Generic;

namespace Parcel.Models
{
    public class Package
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int Volume { get; set; }
        public int Cost { get; set; }

        public Package (int length, int width, int height, int weight)
        {
            Length = length;
            Width = width;
            Height = height;
            Weight = weight;
            Volume = 0;
            Cost = 0;
        }

        public void GetVolume()
        {
            int packageVolume = (Length * Width * Height);
            Volume = packageVolume;
        }

        public void GetCost()
        {
            if (Volume > 25000)
            {
                Cost = Weight + (Volume / 1000);
            }
            else
            {
                Cost = Weight + (Volume / 2000);
            }
        }
    }
}