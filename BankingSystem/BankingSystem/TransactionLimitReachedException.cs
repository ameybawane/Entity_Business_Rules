namespace BankingSystem
{
    public class TransactionLimitReachedException : Exception
    {
        public TransactionLimitReachedException() : base("Transaction limit per account holder is 3.")
        {
        }
    }
}
