using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftwareTest.Utilities
{
    public class CourierPrices
    {
        public enum Couriers
        {
            None,
            Cargo4You,
            ShipFaster,
            MaltaShip
        };

        public static float GetCourierPrice(int id, int volume, float weight)
        {
            Couriers courier = (Couriers)id;
            float dimensionPrice = 0;
            float weightPrice = 0;
            switch (courier)
            {
                case (Couriers.Cargo4You):
                    if (volume <= 1000)
                        dimensionPrice = 10;
                    else
                        dimensionPrice = 20;

                    if (weight <= 2)
                        weightPrice = 15;
                    else if (weight > 2 && weight <= 15)
                        weightPrice = 18;
                    else
                        weightPrice = 35;
                    break;
                case (Couriers.ShipFaster):
                    if (volume <= 1000)
                        dimensionPrice = 11.99f;
                    else
                        dimensionPrice = 21.99f;

                    if (weight > 10 && weight <= 15)
                        weightPrice = 16.5f;
                    else if (weight > 15 && weight <= 25)
                        weightPrice = 36.50f;
                    else
                    {
                        int overCharge = (int)(weight - 25);
                        weightPrice = 25 + 0.417f * overCharge;
                    }
                    break;
                case (Couriers.MaltaShip):
                    if (volume <= 1000)
                        dimensionPrice = 9.5f;
                    else if (volume > 1000 && volume <= 2000)
                        dimensionPrice = 19.5f;
                    else if (volume > 2000 && volume <= 5000)
                        dimensionPrice = 48.5f;
                    else
                        dimensionPrice = 147.50f;

                    if (weight > 10 && weight <= 20)
                        weightPrice = 16.99f;
                    else if (weight > 20 && weight <= 30)
                        weightPrice = 33.99f;
                    else
                    {
                        int overCharge = (int)(weight - 25);
                        weightPrice = 25 + 0.410f * overCharge;
                    }
                    break;
            }
            
            var finalPrice = (dimensionPrice >= weightPrice) ? dimensionPrice : weightPrice;
            return finalPrice;
        }
    }
}