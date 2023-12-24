namespace Promotions.Services
{
    public abstract class DiscountHandler
    {
        protected DiscountHandler _nextHandler;
        public DiscountHandler SetNextHandler(DiscountHandler nextHandler)
        {
            _nextHandler = nextHandler;
            return _nextHandler;
        }
        public abstract decimal CalculateDiscount(string userType, decimal price);
    }
}
