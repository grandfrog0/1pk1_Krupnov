using Task_20_03.Publications;

namespace Task_20_03
{
    /* Создайте программу для управления статусом заказа в интернет-магазине. 
     * Используйте перечисление OrderStatus со значениями:
     * New (новый)
     * Processing (в обработке)
     * Shipped (отправлен)
     * Delivered (доставлен)
     * Cancelled (отменён)
     * Напишите метод, который меняет статус заказа. 
     * Если заказ уже доставлен или отменён, запретите изменение статуса. 
     * Выводите сообщение при каждом изменении статуса (например, "Заказ переведён в статус: Отправлен")
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            StatusManager.SetOrderStatus(OrderStatus.Shipped);
            StatusManager.SetOrderStatus(OrderStatus.Delivered);

            StatusManager.SetOrderStatus(OrderStatus.Shipped); // Не сработает - заказ уже отправлен.

            StatusManager.SetOrderStatus(OrderStatus.New); // Новый заказ
            StatusManager.SetOrderStatus(OrderStatus.Cancelled);

            StatusManager.SetOrderStatus(OrderStatus.Delivered); // Отменённый заказ нельзя доставить.
        }
    }
}
