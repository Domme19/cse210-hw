using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // GoaL running
        GoalManager goalManager = new GoalManager();
        
        // run goalManager
        goalManager.Start(); 
    }
}