namespace Enumeracao.Entities.Enums
{
    /**
     * 
     * Aqui estou dizendo que cada valor de OrderStatus
     * é um valor inteiro
     * 
     **/
    enum OrderStatus : int
    {
        /**
         * 
         * Você pode colocar de duas maneira, uma aonde o C# coloca
         * como padrao os valores do "tipo enum" e outro você mesmo
         * coloca os valores.
         * 
         **/
        PendingPayment,
        Processing,
        Shipped,
        Delivered
    }
}
