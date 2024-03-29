﻿using System;
using ExerciseOnSolid.Devices;
using ExerciseOnSolid.Networks;
using ExerciseOnSolid.NetworkServices;
using System.Collections.Generic;

namespace ExerciseOnSolid
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var lucasSmartPhone = new SmartPhone(new SkynetWireless() {DevicePhoneNumber = "503-867-5309"});
            var petersSmartPhone = new SmartPhone(new SkynetWireless() {DevicePhoneNumber = "503-555-9876"});
            var lanasSmartWatch = new CellularSmartWatch(new SkynetWireless() {DevicePhoneNumber = "503-555-1234"});
            var wafflesChildPhone = new ChildPhone(new LegionWireless() {DevicePhoneNumber = "503-555-4321"});


            var devices = new List<ICall>();
            devices.Add(lucasSmartPhone);
            devices.Add(petersSmartPhone);
            devices.Add(lanasSmartWatch);
            devices.Add(wafflesChildPhone);

            foreach (var device in devices)
            {
                device.PlaceCall("8765309");
            }

            Console.WriteLine("A day in the Cordova household with two Doodles...");

            Console.Write("\nWaffles places phone call to Dad Lucas because he wants a walk.  ARF!");
            Console.WriteLine(wafflesChildPhone.PlaceCall(lucasSmartPhone.PhoneNumber) == NetworkStatus.OperationSucceed
                ? "\tSuccess"
                : "\tFails");

            Console.Write("\nLana texts Dad Peter because she wants a treat. ARF, ARF!");
            Console.WriteLine(lanasSmartWatch.SendTextMessage(petersSmartPhone.PhoneNumber, "ARF!  Dad, I want a treat!") == NetworkStatus.OperationSucceed
                ? "\tSuccess"
                : "\tFails");

            Console.Write("\nLucas places video call to Peter to tell him he will walk Waffles and asks him to order more treats.");
            Console.WriteLine(lucasSmartPhone.PlaceVideoCall(petersSmartPhone.PhoneNumber) == NetworkStatus.OperationSucceed
                ? "\tSuccess"
                : "\tFails");

            Console.Write("\nPeter orders new treats off DoodleTreats.com");
            Console.WriteLine(petersSmartPhone.BrowseInternet(@"https://www.doodletreats.com") == NetworkStatus.OperationSucceed
                ? "\tSuccess"
                : "\tFails");
        }
    }
}
