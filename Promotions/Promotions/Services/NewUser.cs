using Promotions.Enums;

namespace Promotions.Services
{
    public class NewUserHandler : DiscountHandler
    {
        public override decimal CalculateDiscount(string userType, decimal price)
        {
            if (userType.ToLower() == UserTypeEnum.New.ToString().ToLower())
            {
                return price * 0.95m;
            }
            return _nextHandler.CalculateDiscount(userType, price);
        }
    }
}
