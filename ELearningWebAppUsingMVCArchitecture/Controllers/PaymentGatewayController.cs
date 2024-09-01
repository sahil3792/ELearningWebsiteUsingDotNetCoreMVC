using ELearningWebAppUsingMVCArchitecture.Models;
using ELearningWebAppUsingMVCArchitecture.Repo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Razorpay.Api;

namespace ELearningWebAppUsingMVCArchitecture.Controllers
{
	public class PaymentGatewayController : Controller
	{
		private readonly GatewayRepo repo;

		public PaymentGatewayController(GatewayRepo repo)
		{ 
			this.repo = repo;
        }
		public IActionResult Order(int courseId)
		{
            var course = repo.DisplaySingleCourse(courseId).FirstOrDefault();

            if (course == null)
            {
                return NotFound("Course not found.");
            }

            try
            {
                // Initialize Razorpay client
                var key = "rzp_test_4DrJJevYZkd0No"; // Replace with your Razorpay Key ID
                var secret = "3oX1Dvxlpy2wB3BGnDPxGtH8"; // Replace with your Razorpay Secret

                var client = new RazorpayClient(key, secret);

                // Define order options
                var options = new Dictionary<string, object>
                {
                    { "amount", course.CoursePrice * 100 }, // Amount in paise
                    { "currency", "INR" },
                    { "receipt", "order_rcptid_" + courseId }
                };

                // Create order
                var order = client.Order.Create(options);

                // Pass order details to the view
                ViewBag.CourseId = courseId;
                ViewBag.OrderId = order["id"].ToString();
                ViewBag.CourseName = course.CourseName;
                ViewBag.Amount = course.CoursePrice;
                ViewBag.Currency = "INR";

                return View();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine($"Error: {ex.Message}");
                return StatusCode(500, "An unexpected error occurred. Please try again later.");
            }
        }
        [HttpGet]
        public IActionResult PaymentSuccess(string paymentId, string orderId, string signature, string courseid)
        {
            var username = HttpContext.Session.GetString("User");
            var course = repo.DisplaySingleCourse(int.Parse(courseid)).FirstOrDefault();
            repo.AddOrder(orderId, int.Parse(courseid), course.CoursePrice, username);
            TempData["Msg"] = "Successfully added course to My Courses";

            




            

            return RedirectToAction("Courses","Index"); // Create a PaymentSuccess.cshtml view to show a success message
        }
    }
    




}
