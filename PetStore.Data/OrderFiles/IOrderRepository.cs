namespace PetStore.Data.OrderFiles
{
    public interface IOrderRepository
    {
        void AddOrder(Order order);
        Order GetOrder(int id);
    }
}