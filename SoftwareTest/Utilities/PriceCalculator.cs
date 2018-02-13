using SoftwareTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApplicationContext = SoftwareTest.Contexts.AppContext;

namespace SoftwareTest.Utilities
{
    public class PriceCalculator
    {
        public static List<Courier> GetCourierList(int width, int height, int depth, float weight)
        {
            var volume = width * height * depth;
            try
            {
                using (var db = new ApplicationContext())
                {
                    var result = db.Couriers
                            .Where(x => (x.minSize <= volume && x.maxSize >= volume && weight >= x.minWeight && weight <= x.maxWeight))
                            .ToList();

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static float GetBestPrice(List<Courier> courierIdList, int width, int height, int depth, float weight)
        {
            var volume = width * height * depth;
            List<float> priceList = new List<float>();
            foreach(var item in courierIdList)
            {
                var price = CourierPrices.GetCourierPrice(item.id, volume, weight);
                priceList.Add(price);
            }
            var bestPrice = priceList.Min();
            return bestPrice;
        }
        
    }
}