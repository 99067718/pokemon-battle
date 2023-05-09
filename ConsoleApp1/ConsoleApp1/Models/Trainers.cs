﻿namespace ConsoleApp1.Models
{
    public class Trainers
    {
        public string Gender { get; set; }
        public string Name { get; set; }
        public Inventory Inventory { get; set; }

        public Trainers(string gender, string name, Inventory inv) { 
            if(gender.Replace(" ", "") != "" || gender != null)
            {
                Gender = gender;
            }
            else
            {
                Gender = "Attack Helicopter";
            }
            
            if(name.Replace(" ", "") != "" || name != null)
            {
                Name = name;
            }
            else
            {
                Name = "Pieter";
            }
            
            Inventory = inv;
        }
    }
}
