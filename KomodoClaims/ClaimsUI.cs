using KomodoClaimsRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoClaims
{
    public class ClaimsUI
    {
        private readonly ClaimsRepo _claimRepo;
        public ClaimsUI()
        {
            _claimRepo = new ClaimsRepo();
        }
        public void Run()
        {
            DisplayMenu();
        }
        public void DisplayMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Welcome back Claims Agent. Please select an option below!: \n" +
                    "1. Show all claims \n" +
                    "2. Take care of next claim \n" +
                    "3. Enter a new claim \n" +
                    "4. Exit");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        //Show all Items on Menu
                        ShowAllClaims();
                        break;
                    case "2":
                        //Creating a Menu Item
                        TakeCareOfNextClaim();
                        break;
                    case "3":
                        //Removing a Menu Item
                        EnterANewClaim();
                        break;
                    case "4":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number bewtween 1 and 4");
                        break;
                }
            }
        }
        private void ShowAllClaims()
        {
            Console.Clear();
            Claim claim = _claimRepo.GetMenu();
            if (claim == null || claim.Claims == null || !claim.Claims.Any())
            {
                Console.WriteLine("No Menu Items Available.");
                Console.ReadLine();
                return;
            }
            foreach (Claim menuItem in claim.Claims)
            {
                //Console Write (Display Content)
                Console.WriteLine($"ClaimID: {Claim.ClaimID}");
                Console.WriteLine($"ClaimType: { Claim.ClaimType}");
                Console.WriteLine($"ClaimDescription: { Claim.ClaimDescription}");
                Console.WriteLine($"ClaimAmount: { Claim.ClaimAmount}");
                Console.WriteLine($"DateOfTime: { Claim.DatOfTime}");
                Console.WriteLine($"DateOfClaim: { Claim.DateOfClaim}");
            }
            Console.ReadLine();
        }
        private void TakeCareOfNextClaim()
        {
            Console.Clear();
            Console.WriteLine("Please enter the Claim ID #: ");
            int ClaimID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Please enter the Claim Type: ");
            string ClaimType = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Please enter the Claims Description");
            string ClaimDescription = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Please enter the Claim Amount");
            string ClaimAmount = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Please enter the Date of Accident");
            string DateOfAccident = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Please enter the Date of Claim");
            string DateOfClaim = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Please enter if the Claim isValid (True/False)");
            string IsValid = Console.ReadLine();
            Console.WriteLine();
        }
        private void EnterANewClaim()
        {
            Console.Clear();
            Console.WriteLine("Enter the ClaimID Number you would like to remove from the List:");
            var mealNumber = Convert.ToInt32(Console.ReadLine());
            var isDeleted = _claimRepo.RemoveMenuItemByClaimID(claimID);
            if (isDeleted)
                Console.WriteLine("Removal successful");
            else
                Console.WriteLine("Removal failed");
            Console.ReadLine();
        }
    }
}