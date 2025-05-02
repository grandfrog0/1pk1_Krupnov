namespace Task_20_03.Publications
{
    /// <summary>
    /// Статический класс для управления статусом заказа
    /// </summary>
    static class StatusManager
    {
        /// <summary>
        /// Текущий статус заказа
        /// </summary>
        public static OrderStatus Status { get; private set; }
        private static string[] orderTexts = new string[] { "Новый", "В обработке", "Отправлен", "Доставлен", "Отменён"};

        /// <summary>
        /// Изменить статус заказа
        /// </summary>
        /// <param name="status"></param>
        public static void SetOrderStatus(OrderStatus status)
        {
            if ((Status == OrderStatus.Delivered || Status == OrderStatus.Cancelled) && status != OrderStatus.New)
            {
                Console.WriteLine($"Статус заказа больше недоступен для изменения. Заказ уже {orderTexts[(int)Status].ToLower()}.");
                return;
            }

            Status = status;
            Console.WriteLine($"Заказ переведён в статус: {orderTexts[(int)Status]}");
        }
    }
}
