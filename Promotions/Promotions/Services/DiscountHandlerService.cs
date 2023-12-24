namespace Promotions.Services
{
    public abstract class DiscountHandlerService
    {
        //public decimal OrderHandler(string userType, decimal price)
        //{
        //    if (userType == "new")
        //    {
        //        price = price * 0.95m;
        //    }
        //    if (userType == "regular")
        //    {
        //        price = price * 0.90m;
        //    }
        //    if (userType == "vip")
        //    {
        //        price = price * 0.80m;
        //    }
        //    return price;

        //}
        public abstract decimal OrderHandler(string userType, decimal price);

    }
}
