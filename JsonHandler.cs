using System;
using CsvHelper;
using System.Collections;
using System.Globalization;
using System.IO;
using Newtonsoft.Json;


public class JsonHandler{

    public static Address cnvertjson(){
    string filepath = "/home/arivusurya/dailyAssingment/day28Address/Address.json";
    Address address = new Address();
    List<Address> addressData = JsonConvert.DeserializeObject<List<Address>>(File.ReadAllText(filepath));
    
    foreach(var data in addressData ){
                
                address.name = data.name;
                address.city=data.city;
                address.email=data.email;
                address.number=data.number;
                address.zip=data.zip;
                address.address = data.address;
            }
    return address;
    }
}