using System;
using System.Collections.Generic;
using System.Configuration;
using Models;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace CarPool
{
    public class UserInterface
    {
        #region[GetString]
        public static string GetString()
        {
            try
            {
                string str= Console.ReadLine();
                if (ValidateStringLength(str))
                {
                    return str;
                }
                else
                {
                    Console.WriteLine("Please enter valid string");
                    return GetString();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}--Please enter valid data");
                return GetString();
            }
        }
        #endregion

        #region[ValidateStringLength]
        public static bool ValidateStringLength(string str)
        {
            try
            {
                bool isValid = false;
                if (str.Length > 0)
                {
                    isValid = true;
                    return isValid;
                }
                else
                {
                    return isValid;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            
        }
        #endregion

        #region[GetAdharNo]
        public static long GetAdharNo()
        {
            try
            {
                long adharNo = GetLong();
                if (ValidateAdharNo(adharNo))
                {
                    return adharNo;
                }
                Console.WriteLine("Please Enter Valid Adhar");
                return GetAdharNo();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }
        #endregion

        #region[ValidateAdharNo]
        public static bool ValidateAdharNo(long adharNo)
        {
            return Regex.IsMatch(adharNo.ToString(),Constants.AdharNoPattern);
        }
        #endregion

        #region[GetMobileNo]
        public static long GetMobileNo()
        {
            long mobileNo = GetLong();
            if (ValidateMobileNo(mobileNo))
            {
                return mobileNo;
            }
            Console.WriteLine("Please Enter Valid Mobile No");
            return GetMobileNo();
        }
        #endregion

        #region[ValidateMobileNo]
        public static bool ValidateMobileNo(long mobileNo)
        {
            return Regex.IsMatch(mobileNo.ToString(), Constants.MobileNoPattern);
        }
        #endregion

        #region[GetVehicleNo]
        public static string GetVehicleNo()
        {
            string vehicleNo = Console.ReadLine();
            if (ValidateVehicleNo(vehicleNo))
            {
                return vehicleNo;
            }
            Console.WriteLine("Please Enter Valid VehicleNo");
            return GetVehicleNo();
        }
        #endregion

        #region[ValidateVehicleNo]
        public static bool ValidateVehicleNo(string vehicleNo)
        {
            return Regex.IsMatch(vehicleNo, Constants.VehicleNoPattern);
        }
        #endregion

        #region[ValidateName]
        public static string ValidateName(string name)
        {
            try
            {
                if (!(name.All(char.IsLetter)))
                {
                    Console.WriteLine("Please enter valid name");
                    return null;
                }
                return name;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return null;
        }
        #endregion

        #region[GetName]
        public static string GetName()
        {
            try
            {
                string name = ValidateName(GetString());
                if (name == null)
                {
                    return GetName();
                }
                return name;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        #endregion

        #region[GetInt]
        public static int GetInt()
        {
            try
            {
                if (Int32.TryParse(Console.ReadLine(), out int number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Please enter valid Number");
                    return GetInt();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }
        #endregion

        #region[GetLong]
        public static long GetLong()
        {
            try
            {
                if (Int64.TryParse(Console.ReadLine(), out long number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Please enter valid input");
                    return GetLong();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }
        #endregion

        #region[GetFloat]
        public static float GetFloat()
        {
            try
            {
                float number;
                if (float.TryParse(Console.ReadLine(), out number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Please enter valid input");
                    return GetFloat();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }
        #endregion

        #region[DisplayGender]
        public static void DisplayGender()
        {
            StringBuilder printGender = new StringBuilder();
            printGender.AppendLine("Please Enter");
            printGender.AppendLine("1.Female");
            printGender.AppendLine("2.Male");
            Console.Write(printGender);
        }
        #endregion

        #region[GetGender]
        public static Gender GetGender()
        {
            try
            {
                DisplayGender();
                int selectGender = GetInt();
                switch (selectGender)
                {
                    case 1:
                        return Gender.Female;
                    case 2:
                        return Gender.Male;
                    default:
                        Console.WriteLine("Please Enter Valid Option");
                        return GetGender();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return GetGender();
            }
        }
        #endregion

        #region[DisplayUserAccess]
        public static void DisplayUserAccess()
        {
            StringBuilder displayuserAccess = new StringBuilder();
            displayuserAccess.AppendLine("Please Enter");
            displayuserAccess.AppendLine("1.Login");
            displayuserAccess.AppendLine("2.SignUp");
            displayuserAccess.AppendLine("3.Forgotpassword");
            displayuserAccess.AppendLine("4.DisplayAllRides");
            displayuserAccess.AppendLine("5.Exit");
            Console.Write(displayuserAccess);
        }
        #endregion

        #region[DisplayUserOperations]
        public static void DisplayUserOperations()
        {
            StringBuilder userOperations = new StringBuilder();
            userOperations.AppendLine("Please Enter");
            userOperations.AppendLine("1.OfferRide");
            userOperations.AppendLine("2.GetRide");
            userOperations.AppendLine("3.AddMoneyToWallet");
            userOperations.AppendLine("4.DisplayBookingHistory");
            userOperations.AppendLine("5.ViewWalletBalance");
            //userOperations.AppendLine("6.AddReview");
            userOperations.AppendLine("7.Exit Account");
            Console.Write(userOperations);
        }
        #endregion

        #region[UpdateJsonFile]
        public static Pool UpdateJsonFile(Pool poolObj)
        {
            try
            {
                string text = Startup.JSONOperationObj.Serialize(poolObj);
                Startup.FileOperationObj.Write(text, Startup.Path);
                return ReadJsonFileAsObject();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            
        }
        #endregion

        #region[ReadJsonFileAsObject]
        public static Pool ReadJsonFileAsObject()
        {
            string text = Startup.FileOperationObj.Read(Startup.Path);
            Pool poolObj = Startup.JSONOperationObj.Deserialize(text);
            return poolObj;
        }
        #endregion

        #region[Start]
        public static void Start(Pool poolObj)
        {
            Console.WriteLine("Welcome to CarPool");
            UserInterface.Init(poolObj);
        }
        #endregion

        #region[Init]
        public static void Init(Pool poolObj)
        {
            try
            {
                bool isTrue = true;
                poolObj = ReadJsonFileAsObject();
                while (isTrue)
                {
                    DisplayUserAccess();
                    int userOption = GetInt();
                    switch (userOption)
                    {
                        case 1:
                            if(poolObj.Users.Count>0)
                            {
                                Models.User user = Login(poolObj.Users);
                                if (user != null)
                                {
                                    DisplayToGetRequestedRidesStatus(user, poolObj);
                                    DisplayConformedRides(user, poolObj.Users, poolObj.Requests, poolObj.Rides);
                                    RideCompleted(user, poolObj);
                                    poolObj = ReadJsonFileAsObject();
                                    UserAccess(user, poolObj);
                                }
                                Init(poolObj);
                            }
                            else
                            {
                                Console.WriteLine("invalid user please signup");
                            }
                            break;
                        case 2:
                            SignUp(poolObj.Users);
                            poolObj = UpdateJsonFile(poolObj);
                            Init(poolObj);
                            break;
                        case 3:
                            Forgotpassword(poolObj.Users);
                            poolObj = UpdateJsonFile(poolObj);
                            Init(poolObj);
                            break;
                        case 4:
                            DisplayAllRideOffers(poolObj.Rides);
                            break;
                        case 5:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Please Enter Valid Option");
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        #endregion

        #region[RideCompleted]
        public static void RideCompleted(User user,Pool poolObj)
        {
            if (user.ConfirmationIds.Count>0)
            {
                foreach (var req in user.ConfirmationIds)
                {
                    var request = poolObj.Requests.Where(r => r.Id == req).FirstOrDefault();
                    var ride = poolObj.Rides.Where(r => r.Id == request.RideId).FirstOrDefault();
                    if (ride.Status!=Status.Completed || ride.Status!=Status.Cancelled)
                    {
                        if (IsRideCompleted())
                        {
                            Startup.RideServiceObj.CompleteRide(ride);
                            var receiver = poolObj.Users.Where(u => u.Id == request.OffererId).FirstOrDefault();
                            Payment payment=Startup.PaymentServiceObj.TransferFunds(user.Wallet, receiver.Wallet, CalculateCost(ride,request.Route));
                            Startup.PaymentServiceObj.AddPayment(payment, poolObj.Payments);
                            poolObj = UpdateJsonFile(poolObj);
                            PaymentSumarry(payment, user, receiver,poolObj);

                        }
                    }
                }
            }
        }
        #endregion

        #region[PaymentSumarry]
        public static void PaymentSumarry(Payment payment,User user,User receiver,Pool poolObj)
        {
            PaymentReceipt paymentReceipt = GeneratePaymentReceipt(payment);
            PaymentReceipt debitorPaymentReceipt = PaymentReceiptDebitor(paymentReceipt, user);
            Startup.PaymentReceiptServiceObj.AddReceipt(debitorPaymentReceipt, user);
            PaymentReceipt creditorPaymentReceipt = PaymentReceiptCreditor(paymentReceipt, receiver);
            Startup.PaymentReceiptServiceObj.AddReceipt(creditorPaymentReceipt, receiver);
            poolObj = UpdateJsonFile(poolObj);
        }
        #endregion

        #region[GeneratePaymentReceipt]
        public static PaymentReceipt GeneratePaymentReceipt(Payment payment)
        {
            return new PaymentReceipt() { PaymentId = payment.Id, Status = PaymentStatus.Successful, Amount = payment.Amount, Mode = Mode.Debit };
        }
        #endregion

        #region[PaymentReceiptDebitor]
        public static PaymentReceipt PaymentReceiptDebitor(PaymentReceipt paymentReceipt,User user)
        {
            paymentReceipt.Balance = user.Wallet.Balance;
            paymentReceipt.Mode = Mode.Debit;
            return paymentReceipt;
        }
        #endregion

        #region[PaymentReceiptCreditor]
        public static PaymentReceipt PaymentReceiptCreditor(PaymentReceipt paymentReceipt,User receiver)
        {
            paymentReceipt.Balance = receiver.Wallet.Balance;
            paymentReceipt.Mode = Mode.Credit;
            return paymentReceipt;
        }
        #endregion

        #region[IsRideCompleted]
        public static bool IsRideCompleted()
        {
            bool isRideCompleted = false;
            DisplayToGetRideCompletedOrNot();
            int number = GetInt();
            switch (number)
            {
                case 1:
                    isRideCompleted = true;
                    return isRideCompleted;
                case 2:
                    return isRideCompleted;
                default:
                    Console.WriteLine("Please enter valid number");
                    return IsRideCompleted();
            }
        }
        #endregion

        #region[DisplayToGetRideCompletedOrNot]
        public static void DisplayToGetRideCompletedOrNot()
        {
            Console.WriteLine("Is Ride Completed:");
            Console.WriteLine("1.Yes");
            Console.WriteLine("2.No");
        }
        #endregion

        #region[UserAccess]
        public static void UserAccess(User user, Pool poolObj)
        {
            try
            {
                DisplayUserOperations();
                int option = GetUserOption();
                SelectUserOperation(user, option, poolObj);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        #endregion

        #region[GetUserOption]
        public static int GetUserOption()
        {
            return GetInt();
        }
        #endregion

        #region[SelectUserOperation]
        public static void SelectUserOperation(User user, int option, Pool poolObj)
        {
            try
            {
                switch (option)
                {
                    case 1:
                        bool hasDrivingLicence = CheckIfUserHasDrivingLicence(user.DrivingLicenseNo);
                        if (hasDrivingLicence)
                        {
                            OfferRide(user, poolObj);
                        }
                        else
                        {
                            if (DisplayToGetDrivingLicence(user) != null)
                            {
                                OfferRide(user, poolObj);
                            }
                            else
                            {
                                Console.WriteLine("Sorry cant offer a ride");
                            }
                        }
                        UserAccess(user, poolObj);
                        break;
                    case 2:
                        Route route = GetRideDetails(poolObj.Rides);
                        bool hasExistingRide = DoesRideExist(route, poolObj.Rides);
                        if (hasExistingRide)
                        {
                            List<Ride> rides = GetRides(route, poolObj.Rides);
                            DisplayAvailableRides(rides, poolObj.Users,route);
                            Ride ride = GetSelectedRide(rides);
                            if (Startup.WalletServiceObj.HasSufficientbalance(user.Wallet, ride.Cost))
                            {
                                User RideOfferer = GetRideOfferer(ride.Id, poolObj.Rides, poolObj.Users);
                                RaiseRequest(RideOfferer, user, ride.Id, poolObj,route);
                                Console.WriteLine("Request Raised Successfuly");
                                poolObj = UpdateJsonFile(poolObj);
                            }
                            else
                            {
                                Console.WriteLine("Sorry there is no enough Wallet balance Please add Money");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Sorry No available rides");
                        }
                        UserAccess(user, poolObj);
                        break;
                    case 3:
                        DisplayBalance(DepositToWallet(user,poolObj));
                        poolObj = UpdateJsonFile(poolObj);
                        UserAccess(user, poolObj);
                        break;
                    case 4:
                        RideHistory(poolObj.Rides, user.Id);
                        UserAccess(user, poolObj);
                        break;
                    case 5:
                        DisplayBalance(Startup.WalletServiceObj.ViewBalance(user.Wallet));
                        UserAccess(user, poolObj);
                        break;
                    case 6:
                        //Addreview
                        break;
                    case 7:
                        break;
                    default:
                        Console.WriteLine("Please Enter valid option");
                        UserAccess(user, poolObj);
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        #endregion

        #region[OfferRide]
        public static void OfferRide(User user,Pool poolObj)
        {
            try
            {
                Ride ride = CreateRide(user, poolObj);
                Startup.RideServiceObj.AddRide(poolObj.Rides, ride);
                poolObj = UpdateJsonFile(poolObj);
                Console.WriteLine("Ride created successfully");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        #endregion

        #region[DisplayAllRideOffers]
        public static void DisplayAllRideOffers(List<Ride> rides)
        {
            try
            {
                if (rides.Count > 0)
                {
                    foreach (var ride in rides)
                    {
                        if (ride.IsVacant)
                        {
                            Console.WriteLine($"{ride.Id}--{ride.Route.Source}--{ride.Route.Destination}--{ride.Cost}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No existing Rides");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            } 
        }
        #endregion

        #region[DisplayAllBookings]
        public static void DisplayAllBookings(List<Booking> bookings)
        {
            try
            {
                if (bookings.Count > 0)
                {
                    foreach (var booking in bookings)
                    {
                        Console.WriteLine($"{booking.RideId}--{booking.UserId}");
                    }
                }
                else
                {
                    Console.WriteLine("No existing offer");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        #endregion

        #region[DisplayBalance]
        public static void DisplayBalance(float balance)
        {
            Console.WriteLine($"Your account balance is  {balance}");
        }
        #endregion

        #region[DepositToWallet]
        public static float DepositToWallet(User user,Pool poolObj)
        {
            try
            {
                Console.WriteLine("Please Enter Amount:");
                float amount = GetFloat();
                user.Wallet= Startup.WalletServiceObj.AddBalance(user.Wallet, amount);
                poolObj.Users.Where(u => u.Id == user.Id).FirstOrDefault().Wallet = user.Wallet;
                poolObj = UpdateJsonFile(poolObj);
                return user.Wallet.Balance;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }

        }
        #endregion

        #region[RideHistory]
        public static void RideHistory(List<Ride> rides, string userId)
        {
            try
            {
                DisplayRideHistory(Startup.RideServiceObj.GetRideHistory(rides, userId));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        #endregion

        #region[DisplayRideHistory]
        public static void DisplayRideHistory(List<Ride> rides)
        {
            try
            {
                Console.WriteLine("SOURCE    DESTINATION    STATUS");
                foreach (var ride in rides)
                {
                    Console.WriteLine($"{ride.Route.Source}    {ride.Route.Destination}    {ride.Status}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        #endregion

        #region[CheckIfUserHasDrivingLicence]
        public static bool CheckIfUserHasDrivingLicence(string drivingLicenceNo)
        {
            bool hasDrivingLicence = false;
            if (drivingLicenceNo != null)
            {
                hasDrivingLicence = true;
                return hasDrivingLicence;
            }
            return hasDrivingLicence;
        }
        #endregion

        #region[DisplayToGetDrivingLicence]
        public static string DisplayToGetDrivingLicence(User user)
        {
            try
            {
                Console.WriteLine("Do you have driving Licence");
                Console.WriteLine("1.Yes");
                Console.WriteLine("2.No");
                int option = GetInt();
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Please Enter DrivingLicence");
                        user.DrivingLicenseNo = GetString();
                        return user.DrivingLicenseNo;
                    case 2:
                        return null;
                    default:
                        Console.WriteLine("Please Enter valid option");
                        return DisplayToGetDrivingLicence(user);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            
        }
        #endregion

        #region[CreateRide]
        public static Ride CreateRide(User user, Pool poolObj)
        {
            try
            {
                Vehicle vehicle = CreateVehicle(user);
                Route route = CreateRoute();
                Console.WriteLine("Please Enter Cost");
                float cost = GetFloat();
                Ride rideObj = new Ride();
                rideObj.Vehicle = vehicle;
                rideObj.Route = route;
                rideObj.Cost = cost;
                rideObj.Status = Status.NotYetStarted;
                rideObj.IsVacant = true;
                Console.WriteLine("Please Enter Number of StopOvers");
                int numberOfStopOvers = GetInt();
                while (numberOfStopOvers > 0)
                {
                    StopOver stopOver = CreateStopOver(vehicle.Capacity -1);
                    rideObj.StopOvers.Add(stopOver);
                    numberOfStopOvers--;
                }
                return rideObj;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

        }
        #endregion

        #region[CreateStopOver]
        public static StopOver CreateStopOver(int vacancy)
        {
            Console.WriteLine("Please Enter Place");
            return new StopOver(vacancy) { Place = GetString() };
        }
        #endregion

        #region[CreateVehicle]
        public static Vehicle CreateVehicle(User user)
        {
            try
            {
                Console.WriteLine("Please Enter Vehicle Number:");
                string number = GetVehicleNo();
                Console.WriteLine("Vehicle Name:");
                string name = GetString();
                Console.WriteLine("Capacity:");
                int capacity = GetInt();
                Vehicle vehicleObj = new Vehicle();
                user.Role = Role.Driver;
                vehicleObj.UserIds.Add(user.Id);
                vehicleObj.Number = number;
                vehicleObj.Name = name;
                vehicleObj.Capacity = capacity;
                return vehicleObj;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

        }
        #endregion

        #region[CreateRoute]
        public static Route CreateRoute()
        {
            try
            {
                Console.WriteLine("Please Enter Source:");
                string source = GetString();
                Console.WriteLine("Destination");
                string destination = GetString();
                Route routeObj = new Route();
                routeObj.Source = source;
                routeObj.Destination = destination;
                return routeObj;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        #endregion

        #region[GetRideDetails]
        public static Route GetRideDetails(List<Ride> rides)
        {
            try
            {
                Console.WriteLine("Please Enter Source:");
                string source = GetString();
                Console.WriteLine("Please Enter Destination");
                string destination = GetString();
                Route routeObj = new Route();
                routeObj.Source = source;
                routeObj.Destination = destination;
                return routeObj;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

        }
        #endregion

        #region[DoesRideExist]
        public static bool DoesRideExist(Route route, List<Ride> rides)
        {
             return rides.Where(ride => ((ride.Route.Source.ToLowerInvariant() == route.Source.ToLowerInvariant() && ride.IsVacant == true) ||
                   ride.StopOvers.Where(stopOver => stopOver.Place.ToLowerInvariant() == route.Source.ToLowerInvariant() && (stopOver.Vacancies > 0)).Any())
                   && ((ride.Route.Destination.ToLowerInvariant() == route.Destination.ToLowerInvariant()) ||
                   (ride.StopOvers.Where(stopOver => stopOver.Place.ToLowerInvariant() == route.Destination.ToLowerInvariant()).Any() &&
                   (ride.StopOvers.IndexOf(ride.StopOvers.Where(stopOver => stopOver.Place.ToLowerInvariant() == route.Destination.ToLowerInvariant()).FirstOrDefault()) >
                   (ride.StopOvers.IndexOf(ride.StopOvers.Where(stopOver => stopOver.Place.ToLowerInvariant() == route.Source.ToLowerInvariant()).FirstOrDefault())))))).Any();
        }
        #endregion

        #region[DisplayConformedRides]
        public static void DisplayConformedRides(User user, List<User> users, List<Request> requests, List<Ride> rides)
        {
            try
            {
                if (user.ConfirmationIds.Count > 0)
                {
                    foreach (var confirmationId in user.ConfirmationIds)
                    {
                        var request = requests.Where(r => r.Id == confirmationId).FirstOrDefault();
                        var offereduser = users.Where(u => u.Id == request.OffererId).FirstOrDefault();
                        var ride = rides.Where(r => r.Id == request.RideId).FirstOrDefault();
                        Console.WriteLine($"{offereduser.Name}--{offereduser.Type}--{offereduser.MobileNo}--accepted your request for ride from--{ride.Route.Source}-to-{ride.Route.Destination}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        #endregion

        #region[DisplayToGetRequestedRidesStatus]
        public static void DisplayToGetRequestedRidesStatus(User user,Pool poolObj)
        {
            try
            {
                bool isVacant = false;
                if (user.RequestIds.Count > 0)
                {
                    foreach (var requestId in user.RequestIds)
                    {
                        var request = poolObj.Requests.Where(r => r.Id == requestId && r.Status==RequestStatus.NotApproved).FirstOrDefault();
                        if(request!=null)
                        {
                            var requesteduser = poolObj.Users.Where(u => u.Id == request.RequesterId).FirstOrDefault();
                            var ride = poolObj.Rides.Where(r => r.Id == request.RideId && r.IsVacant==true).FirstOrDefault();
                            if (ride!=null)
                            {
                                Console.WriteLine($"{requesteduser.Name}--{requesteduser.Type}--requested ride from--{request.Route.Source}-to-{request.Route.Destination}");
                                DisplayRideRequestApproval();
                                request.Status = GetRideRequestStatus(request.Status);
                                if (request.Status == RequestStatus.Conform)
                                {
                                    Console.WriteLine($"Requested user MobileNo {requesteduser.MobileNo}");
                                    Booking booking = CreateBooking(request);
                                    Startup.BookingServiceObj.AddBooking(booking, poolObj.Bookings);
                                    Startup.RequestServiceObj.AddConformationId(requesteduser, request.Id);
                                    ride.Vehicle = Startup.VehicleServiceObj.AddUser(ride.Vehicle, requesteduser);
                                    if (ride.Vehicle.Capacity == ride.Vehicle.UserIds.Count)
                                    {
                                        ride.IsVacant = isVacant;
                                    }
                                    UpdateJsonFile(poolObj);
                                }
                            }
                            else
                            {
                                request.Status = RequestStatus.Rejected;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        #endregion

        #region[CreateBooking]
        public static Booking CreateBooking(Request request)
        {
            try
            {
                return new Booking() { RideId = request.RideId, UserId = request.RequesterId,Route=request.Route };
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        #endregion

        #region[DisplayRideRequestApproval]
        public static void DisplayRideRequestApproval()
        {
            Console.WriteLine("Do You Want to approve the ride");
            Console.WriteLine("1.Yes");
            Console.WriteLine("2.No");
        }
        #endregion

        #region[GetRideRequestStatus]
        public static RequestStatus GetRideRequestStatus(RequestStatus status)
        {
            try
            {
                int number = GetInt();
                switch (number)
                {
                    case 1:
                        return RequestStatus.Conform;
                    case 2:
                        return RequestStatus.NotApproved;
                    default:
                        Console.WriteLine("Please Enter Valid Option");
                        return GetRideRequestStatus(status);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return RequestStatus.NotApproved;
            }
            
        }
        #endregion

        #region[RaiseRequest]
        public static void RaiseRequest(User rideOfferer,User rideRequester,string rideId,Pool poolObj,Route route)
        {
            try
            {
                Request request = new Request();
                request.OffererId = rideOfferer.Id;
                request.RequesterId = rideRequester.Id;
                request.RideId = rideId;
                request.Status = RequestStatus.NotApproved;
                request.Route = new Route();
                request.Route.Source = route.Source;
                request.Route.Destination = route.Destination;
                Startup.RequestServiceObj.AddRequest(poolObj.Requests, request);
                Startup.RequestServiceObj.AddRequestId(rideOfferer, request.Id);
                poolObj = UpdateJsonFile(poolObj);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        #endregion

        #region[GetRideOfferer]
        public static User GetRideOfferer(string rideId, List<Ride> rides,List<User> users)
        {
            try
            {
                var userId = rides.Where(r => r.Id == rideId).FirstOrDefault().Vehicle.UserIds[0];
                return users.Where(u => u.Id == userId).FirstOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        #endregion

        #region[GetRides]
        public static List<Ride> GetRides(Route route, List<Ride> rides)
        {
            return rides.Where(ride => ((ride.Route.Source.ToLowerInvariant() == route.Source.ToLowerInvariant()&&ride.IsVacant==true) || 
                   ride.StopOvers.Where(stopOver => stopOver.Place.ToLowerInvariant() == route.Source.ToLowerInvariant() && (stopOver.Vacancies>0)).Any())
                   && ((ride.Route.Destination.ToLowerInvariant() == route.Destination.ToLowerInvariant()) ||
                   (ride.StopOvers.Where(stopOver => stopOver.Place.ToLowerInvariant() == route.Destination.ToLowerInvariant()).Any() && 
                   (ride.StopOvers.IndexOf(ride.StopOvers.Where(stopOver => stopOver.Place.ToLowerInvariant() == route.Destination.ToLowerInvariant()).FirstOrDefault()) > 
                   (ride.StopOvers.IndexOf(ride.StopOvers.Where(stopOver => stopOver.Place.ToLowerInvariant() == route.Source.ToLowerInvariant()).FirstOrDefault())))))).ToList();

        }
        #endregion

        #region[GetSelectedRide]
        public static Ride GetSelectedRide(List<Ride> rides)
        {
            try
            {
                int number = GetInt();
                int lowerbound = 1;
                if (number >= lowerbound && number <= rides.Count)
                {
                    return rides[number - 1];
                }
                else
                {
                    Console.WriteLine("please enter valid ride");
                    return GetSelectedRide(rides);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            
        }
        #endregion

        #region[DisplayAvailableRides]
        public static void DisplayAvailableRides(List<Ride> rides,List<User> users,Route route)
        {
            try
            {
                Console.WriteLine("NUMBER.  NAME  GENDER  SOURCE  DESTINATION  COST");
                int i = 0;
                Console.WriteLine($"Available ride are:");
                foreach (var ride in rides)
                {
                    var user = users.Where(u => u.Id == ride.Vehicle.UserIds[0]).FirstOrDefault();
                    Console.WriteLine($"{++i}.  {user.Name}  {user.Type}  {route.Source}  {route.Destination}  {CalculateCost(ride,route)}");
                }
                Console.WriteLine("Please Select a ride");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        #endregion

        #region[CalculateCost]
        public static float CalculateCost(Ride ride, Route route)
        {
            return ride.Cost * (ride.StopOvers.IndexOf(ride.StopOvers.Where(stopOver => stopOver.Place.ToLowerInvariant() == route.Destination.ToLowerInvariant()).FirstOrDefault()) - (ride.StopOvers.IndexOf(ride.StopOvers.Where(stopOver => stopOver.Place.ToLowerInvariant() == route.Source.ToLowerInvariant()).FirstOrDefault()))) / (ride.StopOvers.Count + 1);
        }
        #endregion

        #region[Login]
        public static Models.User Login(List<User> users)
        {
            try
            {
                Console.WriteLine("Please Enter UserName:");
                string userName = GetString();
                Console.WriteLine("Please Enter Password:");
                string password = GetString();
                if (Startup.UserServiceObj.DoesUserExist(userName,password,users))
                {
                    User user= Startup.UserServiceObj.GetUser(userName, password, users);
                    Console.WriteLine($"Welcome  {user.Name}");
                    return user;
                }
                else
                {
                    Console.WriteLine("Invalid Credentrials");
                    return null;
                    
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        #endregion

        #region[DisplayIsValidUser]
        public static void DisplayIsValidUser(Models.User user,Pool poolObj)
        {
            if(user!=null)
            {
                Console.WriteLine($"Login Successful----Welcome {user.Name}");
            }
            else
            {
                Console.WriteLine("Sorry Authentication Failed");
                Init(poolObj);
            }
        }
        #endregion

        #region[GetDrivingLicenceNo]
        public static string GetDrivingLicenceNo()
        {
            return GetString();
        }
        #endregion

        #region[DisplayDrivingLicenceOption]
        public static void DisplayDrivingLicenceOption()
        {
            Console.WriteLine("Please Enter");
            Console.WriteLine("1.Yes");
            Console.WriteLine("2.No");
        }
        #endregion

        #region[HasDrivingLicence]
        public static bool HasDrivingLicence()
        {
            try
            {
                bool hasDrivingLicence = false;
                DisplayDrivingLicenceOption();
                int number = GetInt();
                switch (number)
                {
                    case 1:
                        hasDrivingLicence = true;
                        return hasDrivingLicence;
                    case 2:
                        return hasDrivingLicence;
                    default:
                        Console.WriteLine("Please enter valid  option");
                        return HasDrivingLicence();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            
        }
        #endregion

        #region[GetUser]
        public static Models.User GetUser()
        {
            try
            {
                Console.WriteLine("Please Enter Name:");
                string name = GetName();
                Console.WriteLine("Age:");
                int age = GetInt();
                Console.WriteLine("Gender:");
                Gender gender = GetGender();
                Console.WriteLine("Adhar No:");
                Int64 adharNo = GetAdharNo();
                Console.WriteLine("Mobile No:");
                Int64 mobileNo = GetMobileNo();
                Console.WriteLine("Do you have DrivingLicenceNumber:");
                bool hasDrivingLicence = HasDrivingLicence();
                string drivingLicenceNumber;
                drivingLicenceNumber = null;
                if (hasDrivingLicence)
                {
                    Console.WriteLine("Please enter driving licence Number");
                    drivingLicenceNumber = GetDrivingLicenceNo();
                }
                Console.WriteLine("Username:");
                string username = GetString();
                Console.WriteLine("Password");
                string password = GetString();
                bool isActive = true;
                Wallet wallet = new Wallet();
                wallet.Balance = 0;
                User userObj = new Models.User();
                userObj.Name = name;
                userObj.Age = age;
                userObj.Type = gender;
                userObj.AdharNo = adharNo;
                userObj.MobileNo = mobileNo;
                userObj.DrivingLicenseNo = drivingLicenceNumber;
                userObj.UserName = username;
                userObj.Password = password;
                userObj.IsActive = isActive;
                userObj.Wallet = wallet;
                return userObj;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        #endregion

        #region[SignUp]
        public static void SignUp(List<User> users)
        {
            try
            {
                Startup.UserServiceObj.AddUser(GetUser(),users);
                Console.WriteLine("SignUp successful--Login for further services");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        #endregion

        #region[Forgotpassword]
        public static void Forgotpassword(List<User> users)
        {
            try
            {
                Console.WriteLine("Please Enter Username");
                string username = GetString();
                Console.WriteLine("Please Enter AdharNo:");
                long adharNo = GetLong();
                bool isValidUser = Startup.UserServiceObj.IsUserValid(username, adharNo, users);
                if (isValidUser)
                {
                    Console.WriteLine("Please Enter New Password:");
                    string password = GetString();
                    Startup.UserServiceObj.ChangePassword(username, adharNo, password, users);
                }
                else
                {
                    Console.WriteLine("Invalid Credentials");
                    Console.WriteLine("Failed to confirm that account belongs to You");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        #endregion
    }
}
