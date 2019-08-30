using System;
using System.Collections.Generic;

namespace PasswordManager {
    class Program {
        static void Main(string[] args) {

            
            

            var passwordmanage = new Dictionary<string, string>();
            passwordmanage.Add("MaxTrain.com", "Red1");
            passwordmanage.Add("Gmail.com", "Orange2");
            passwordmanage.Add("Yahoo.com", "Yellow3");
            passwordmanage.Add("Facebook.com", "Green4");
            passwordmanage.Add("Twitter.com", "Blue5");
            passwordmanage.Add("Reddit.com", "Indigo6");
            passwordmanage.Add("Coursera.com", "Violet7");
            passwordmanage.Add("Coinbase.com", "Black8");
            passwordmanage.Add("PayPal.com", "White9");
            passwordmanage.Add("Ebay.com", "Brown10");
            passwordmanage.Add("Amazon.com", "Pink11");
            passwordmanage.Add("Netflix.com", "Grey12");

            string bitcoin = passwordmanage["Coinbase.com"];
            Console.WriteLine(bitcoin);

            var password = passwordmanage["Amazon.com"];
            Console.WriteLine($"The password for Amazon.com is {password}");

            foreach(var keyvalpair in passwordmanage) {
                Console.WriteLine($"The password for {keyvalpair.Key} is {keyvalpair.Value}");
            }

            var allTheKeys = passwordmanage.Keys;   //retrieve just keys or just values
            var allTheValues = passwordmanage.Values;  //dictionary does not allow duplicates

            var maxtrain = "maxtrain.com";  //see if it's already in the dictionary
            var exists = passwordmanage.ContainsKey(maxtrain);
        }
    }
}
