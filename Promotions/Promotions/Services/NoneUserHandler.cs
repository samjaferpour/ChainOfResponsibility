namespace Promotions.Services
{
    public class NoneUserHandler : DiscountHandler
    {
        public override decimal CalculateDiscount(string userType, decimal price)
        {
            if (true)
            {
                return price;
            }
            return _nextHandler.CalculateDiscount(userType, price);
        }
    }
}
