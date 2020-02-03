using System;
using System.Collections.Generic;
using System.Text;
using Services;
using Models;
using Interface;
using Operation;
using Microsoft.Extensions.Configuration;

namespace CarPool
{
    class Startup
    {
        public Startup()
        {
            UserServiceObj = new UserService();
            PoolObj = new Pool();
            WalletServiceObj = new WalletServices();
            RideServiceObj = new RideServices();
            BookingServiceObj = new BookingService();
            PaymentServiceObj = new PaymentService();
            ReviewServiceObj = new ReviewService();
            RequestServiceObj = new RequestService();
            PaymentReceiptServiceObj = new PaymentReceiptService();
            VehicleServiceObj = new VehicleService();
            JSONOperationObj = new JSONOperation();
            FileOperationObj = new FileOperation();
        }
        public static readonly string Path = "..\\Pool.Json";
        public static Pool PoolObj { get; set; }
        public static IUserService UserServiceObj { get; set; }
        public static IWalletService WalletServiceObj { get; set; }
        public static IRideService RideServiceObj { get; set; }
        public static IBookingService BookingServiceObj { get; set; }
        public static IPaymentService PaymentServiceObj { get; set; }
        public static IRequestService RequestServiceObj { get; set; }
        public static IReviewService ReviewServiceObj { get; set; }
        public static IPaymentReceiptService PaymentReceiptServiceObj { get; set; }
        public static IVehicleService VehicleServiceObj { get; set; } 
        public static JSONOperation JSONOperationObj { get; set; }
        public static FileOperation FileOperationObj { get; set; }
    }
}
