//using System;

///// <summary>
///// Summary description for Class1
///// </summary>

//public class Customer
//{
//    private List<Account> accountList;
//    private long idNumber;
//    private string fullName;



//    public Customer(string idNumber, string fullName)
//    {
//        this.idNumber = idNumber;
//        this.fullName = fullName;
//        this.accountList = new List<Account>();
//    }

//    public string GetCustomerInfo()
//    {
//        string info = "ID: " + idNumber + "\nFull Name: " + fullName + "\n Accounts:\n";
//        foreach (Account account in accountList)
//        {
//            info += account.GetAccountInfo();
//        }
//        return info;
//    }

//    public void AddAccount(Account account)
//    {
//        accountList.Add(account);
//    }

//    public void RemoveAccount(Account account)
//    {
//        accountList.Remove(account);
//    }
//}
