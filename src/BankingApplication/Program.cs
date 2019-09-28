using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class Program
    {
        public void Main(string[] args)
        {

            #region Accounts Object - Cannot be created are it is Marked as an Abstract Class
            //var accountObj = new Accounts() { AccountNumber = 101, AccountBalance = 5000, AccountName = "Nikhil", AccountType = "Savings" };
            //try
            //{
            //    Console.WriteLine(accountObj.Widraw(300));
            //}
            //catch (Exception expObj)
            //{
            //    Console.WriteLine(expObj.Message);                
            //}
            #endregion

            Console.WriteLine("~~~~~~~~~~~~~~ Welcome to Banking ~~~~~~~~~~~~~~~");
            //Console.WriteLine("Please Choose from the Option");
            //Console.WriteLine("1. Create New Account");
            //Console.WriteLine("2. Widraw");
            //Console.WriteLine("3. Deposit");
            //Console.WriteLine("4. Exit");

            int menuOptionSelected = 0;
            int accountType = 0;
            Savings savObj = null;
            Current currObj = null;
            PF pfObj = null;
            int widrawAmount = 0;
            int depositAmount = 0;
            int continueMore = 1;
           

            while (continueMore == 1)
            {
                Console.WriteLine("Please Choose from the Option");
                Console.WriteLine("1. Create New Account");
                Console.WriteLine("2. Widraw");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Exit");
                menuOptionSelected = Convert.ToInt32(Console.ReadLine());
                switch (menuOptionSelected)
                {
                    #region Open New Account
                    case 1:
                        Console.WriteLine("Which Account You Wish To Open");
                        Console.WriteLine("1. Savings");
                        Console.WriteLine("2. Current");
                        Console.WriteLine("3. PF");
                        accountType = Convert.ToInt32(Console.ReadLine());

                        if (accountType == 1)
                        {
                            savObj = new Savings() { AccountNumber = 101, AccountBalance = 5000, AccountName = "Nikhil" };
                            Console.WriteLine("Savings Account Created With Default values ");
                            Console.WriteLine("Account Number : " + savObj.AccountNumber);
                            Console.WriteLine("Account Name : " + savObj.AccountName);
                            Console.WriteLine("Account Type : " + savObj.AccountType);
                            Console.WriteLine("Account Balance : " + savObj.AccountBalance);
                        }
                        else if (accountType == 2)
                        {
                            currObj = new Current() { AccountNumber = 102, AccountBalance = 5000, AccountName = "Karan" };
                            Console.WriteLine("Current Account Created With Default values ");
                            Console.WriteLine("Account Number : " + currObj.AccountNumber);
                            Console.WriteLine("Account Name : " + currObj.AccountName);
                            Console.WriteLine("Account Type : " + currObj.AccountType);
                            Console.WriteLine("Account Balance : " + currObj.AccountBalance);
                        }
                        else if (accountType == 3)
                        {
                            pfObj = new PF() { AccountNumber = 103, AccountBalance = 25000, AccountName = "Sahil" };
                            Console.WriteLine("Current Account Created With Default values ");
                            Console.WriteLine("Account Number : " + currObj.AccountNumber);
                            Console.WriteLine("Account Name : " + currObj.AccountName);
                            Console.WriteLine("Account Type : " + currObj.AccountType);
                            Console.WriteLine("Account Balance : " + currObj.AccountBalance);

                        }
                        else
                        {
                            Console.WriteLine("Sorry Invalid Account Type, please try Again");
                        }
                        break;
                    #endregion

                    #region Widraw
                    case 2:
                        Console.WriteLine("Choose the Account Type");
                        Console.WriteLine("1. Savings");
                        Console.WriteLine("2. Current");
                        Console.WriteLine("3. PF");
                        accountType = Convert.ToInt32(Console.ReadLine());
                        if (accountType == 1)
                        {
                            if (savObj == null)
                            {
                                savObj = new Savings() { AccountNumber = 101, AccountBalance = 5000, AccountName = "Nikhil" };
                                Console.WriteLine("Account Created with Default values ");
                            }
                            try
                            {
                                Console.WriteLine("Avaialble Balance in Your Account Number 101 : " + savObj.AccountBalance);
                                Console.WriteLine("Enter the Amount to Widraw");
                                widrawAmount = Convert.ToInt32(Console.ReadLine());
                                savObj.Widraw(widrawAmount);
                                Console.WriteLine("Balance After Widrawal " + savObj.AccountBalance);
                            }
                            catch (Exception expObj)
                            {
                                Console.WriteLine(expObj.Message);
                            }
                        }
                        else if (accountType == 2)
                        {
                            if (currObj == null)
                            {
                                currObj = new Current() { AccountNumber = 102, AccountBalance = 5000, AccountName = "Karan" };
                            }
                            Console.WriteLine("Avaialble Balance in Your Account Number 101 : " + currObj.AccountBalance);
                            try
                            {
                                Console.WriteLine("Enter the Amount to Widraw");
                                widrawAmount = Convert.ToInt32(Console.ReadLine());
                                currObj.Widraw(widrawAmount);
                                Console.WriteLine("Balance After Widrawal " + currObj.AccountBalance);
                            }
                            catch (Exception expObj)
                            {
                                Console.WriteLine(expObj.Message);
                            }

                        }
                        else if (accountType == 3)
                        {
                            if (pfObj == null)
                            {
                                pfObj = new PF() { AccountNumber = 103, AccountBalance = 25000, AccountName = "Sahil" };
                            }
                            Console.WriteLine("Avaialble Balance in Your Account Number 101 : 25000");

                            try
                            {
                                Console.WriteLine("Enter the Amount to Widraw");
                                widrawAmount = Convert.ToInt32(Console.ReadLine());
                                pfObj.Widraw(widrawAmount);
                                Console.WriteLine("Balance After Widrawal " + pfObj.AccountBalance);
                            }
                            catch (Exception expObj)
                            {
                                Console.WriteLine(expObj.Message);
                            }


                        }
                        else
                        {
                            Console.WriteLine("Sorry Invalid Account Type, please try Again");
                        }
                        break;
                    #endregion

                    #region Deposit
                    case 3:
                        Console.WriteLine("Choose the Account Type");
                        Console.WriteLine("1. Savings");
                        Console.WriteLine("2. Current");
                        Console.WriteLine("3. PF");
                        accountType = Convert.ToInt32(Console.ReadLine());
                        if (accountType == 1)
                        {
                            if (savObj == null)
                            {
                                savObj = new Savings() { AccountNumber = 101, AccountBalance = 5000, AccountName = "Nikhil" };
                                Console.WriteLine("Account Created with Default values ");
                            }
                            try
                            {
                                Console.WriteLine("Avaialble Balance in Your Account Number 101 : " + savObj.AccountBalance);
                                Console.WriteLine("Enter the Amount to Deposit");
                                depositAmount = Convert.ToInt32(Console.ReadLine());
                                savObj.Deposit(depositAmount);
                                Console.WriteLine("Balance After Deposit " + savObj.AccountBalance);
                            }
                            catch (Exception expObj)
                            {
                                Console.WriteLine(expObj.Message);
                            }
                        }
                        else if (accountType == 2)
                        {
                            if (currObj == null)
                            {
                                currObj = new Current() { AccountNumber = 102, AccountBalance = 5000, AccountName = "Karan" };
                            }
                            Console.WriteLine("Avaialble Balance in Your Account Number 101 : " + currObj.AccountBalance);
                            depositAmount = Convert.ToInt32(Console.ReadLine());
                            try
                            {
                                Console.WriteLine("Enter the Amount to Deposit");
                                depositAmount = Convert.ToInt32(Console.ReadLine());
                                currObj.Deposit(depositAmount);
                                Console.WriteLine("Balance After Deposit " + currObj.AccountBalance);
                            }
                            catch (Exception expObj)
                            {
                                Console.WriteLine(expObj.Message);
                            }

                        }
                        else if (accountType == 3)
                        {
                            if (pfObj == null)
                            {
                                pfObj = new PF() { AccountNumber = 103, AccountBalance = 25000, AccountName = "Sahil" };
                            }
                            Console.WriteLine("Avaialble Balance in Your Account Number 101 : "+ pfObj.AccountBalance);

                            try
                            {
                                Console.WriteLine("Enter the Amount to Deposit");
                                depositAmount = Convert.ToInt32(Console.ReadLine());
                                pfObj.Deposit(depositAmount);
                                Console.WriteLine("Balance After Deposit " + pfObj.AccountBalance);
                            }
                            catch (Exception expObj)
                            {
                                Console.WriteLine(expObj.Message);
                            }


                        }
                        else
                        {
                            Console.WriteLine("Sorry Invalid Account Type, please try Again");
                        }
                        break;
                    #endregion
                    default:
                        Console.WriteLine("Sorry Invalid Menu Option");
                        break;
                }

                Console.WriteLine("   ----------------------------------  ");
                Console.WriteLine("Do you Want to Continue ? ");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                continueMore = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("   ----------------------------------  ");

            }

            Console.WriteLine(" Thank You For Banking with Us ");






        }
    }
}
