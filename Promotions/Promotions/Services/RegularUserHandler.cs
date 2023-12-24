using Promotions.Enums;

namespace Promotions.Services
{
    public class RegularUserHandler : DiscountHandler
    {
        public override decimal CalculateDiscount(string userType, decimal price)
        {
            if (userType.ToLower() == UserTypeEnum.Regular.ToString().ToLower())
            {
                return price * 0.90m;
            }
            return _nextHandler.CalculateDiscount(userType, price);
        }
    }
}
