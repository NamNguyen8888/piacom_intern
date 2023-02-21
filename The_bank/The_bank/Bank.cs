//Transactionusing System;

///// <summary>
///// Summary description for Class1
///// </summary>

//public class Bank
//{
//    private List<Customer> customerList;

//    public Bank()
//    {
//        this.customerList = new List<Customer>();
//    }

//    public void ReadCustomerList(Stream inputStream)
//    {
//        using (var reader = new StreamReader(inputStream))
//        {
//            while (!reader.EndOfStream)
//            {
//                var line = reader.ReadLine();
//                var fields = line.Split(',');

//                var customer = new Customer
//                {
//                    idNumber = fields[0],
//                    fullName = fields[1],
//                    Account = fields[2]
//                };

//                this.customerList.Add(customer);
//            }
//        }
//    }

//    public string GetCustomersInfoByIDOrder()
//    {

//    }

//    public string GetCustomersInfoByNameOrder()
//    {

//    }
//}

