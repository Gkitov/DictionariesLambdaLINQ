using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Dictionary<string, string> parkingDatabase = new Dictionary<string, string>();

        for (int i = 0; i < n; i++)
        {
            string[] command = Console.ReadLine().Split();
            string action = command[0];
            string username = command[1];

            if (action == "register")
            {
                string licensePlateNumber = command[2];
                RegisterUser(parkingDatabase, username, licensePlateNumber);
            }
            else if (action == "unregister")
            {
                UnregisterUser(parkingDatabase, username);
            }
        }

        PrintDatabase(parkingDatabase);
    }

    static void RegisterUser(Dictionary<string, string> parkingDatabase, string username, string licensePlateNumber)
    {
        if (parkingDatabase.ContainsKey(username))
        {
            Console.WriteLine($"ERROR: already registered with plate number {parkingDatabase[username]}");
        }
        else
        {
            parkingDatabase[username] = licensePlateNumber;
            Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
        }
    }

    static void UnregisterUser(Dictionary<string, string> parkingDatabase, string username)
    {
        if (parkingDatabase.ContainsKey(username))
        {
            parkingDatabase.Remove(username);
            Console.WriteLine($"{username} unregistered successfully");
        }
        else
        {
            Console.WriteLine($"ERROR: user {username} not found");
        }
    }

    static void PrintDatabase(Dictionary<string, string> parkingDatabase)
    {
        foreach (var kvp in parkingDatabase)
        {
            Console.WriteLine($"{kvp.Key} => {kvp.Value}");
        }
    }
}
