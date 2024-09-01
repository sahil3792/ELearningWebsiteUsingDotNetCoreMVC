namespace ELearningWebAppUsingMVCArchitecture.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Username { get; set; }    

        public double Amount { get; set; }  

        public int CourseId { get; set; }

        public DateOnly OrderDate { get; set; }
        public DateOnly ExpiryDate { get; set; }

        public string PaymentOrderId { get; set; } 
    }
}
