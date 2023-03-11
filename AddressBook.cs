using System;

public class AddressBook{

    public List<Address> AddressList;
    public AddressBook(){
        AddressList = new List<Address>();
    }

    public void Adddata(){
        Address data = CsvHandler.Adddata();
        AddressList.Add(data);
    }

    public void jsonData(){
        Address datalist =JsonHandler.cnvertjson();

        AddressList.Add(datalist);
    }

    public void Display(){
        foreach(Address item in AddressList){
            Console.WriteLine(item.name);
            Console.WriteLine(item.address);
            Console.WriteLine(item.email);
            Console.WriteLine(item.number);
            Console.WriteLine(item.city);
            Console.WriteLine(item.zip);
        }
    }

}