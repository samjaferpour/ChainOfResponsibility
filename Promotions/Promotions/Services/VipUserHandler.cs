using Promotions.Enums;

namespace Promotions.Services
{
    public class VipUserHandler : DiscountHandler
    {
        public override decimal CalculateDiscount(string userType, decimal price)
        {
            if (userType.ToLower() == UserTypeEnum.Vip.ToString().ToLower())
            {
                return price * 0.80M;
            }
            return _nextHandler.CalculateDiscount(userType, price);
        }
    }
}
