// See https://aka.ms/new-console-template for more information



        string filePath = "khachhang.txt";


        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

