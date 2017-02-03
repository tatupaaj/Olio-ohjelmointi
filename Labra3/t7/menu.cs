using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    class Drinks
    {
        public string Name { get; set; }
        public bool IsItHot { get; set; }
        public bool IsAlcohol { get; set; }
    }

    class Coffee : Drinks
    {
        public bool IsMilk { get; set; }
        public bool IsSugar { get; set; }

        public Coffee()
        {

        }
        public Coffee(string name, bool isithot, bool isalcohol, bool ismilk, bool issugar)
        {
            Name = name;
            IsItHot = isithot;
            IsAlcohol = isalcohol;
            IsMilk = ismilk;
            IsSugar = issugar;
        }
        public string Info()
        {
            return "Name: " + Name + " Is it hot: " + IsItHot + " Is alcohol: " + IsAlcohol + " Is milk: " + IsMilk + " Is sugar: " + IsSugar;
        }
    }

    class Tea : Drinks
    {
        public bool IsSugar { get; set; }

        public Tea()
        {

        }
        public Tea(string name, bool isithot, bool isalcohol, bool issugar)
        {
            Name = name;
            IsItHot = isithot;
            IsAlcohol = isalcohol;
            IsSugar = issugar;
        }
        public string Info()
        {
            return "Name: " + Name + " Is it hot: " + IsItHot + " Is alcohol: " + IsAlcohol + " Is sugar: " + IsSugar;
        }
    }

    class Coctail : Drinks
    {
        public bool IsMilk { get; set; }
        public bool IsIce { get; set; }

        public Coctail()
        {

        }
        public Coctail(string name, bool isithot, bool isalcohol, bool ismilk, bool isice)
        {
            Name = name;
            IsItHot = isithot;
            IsAlcohol = isalcohol;
            IsMilk = ismilk;
            IsIce = isice;
        }
        public string Info()
        {
            return "Name: " + Name + " Is it hot: " + IsItHot + " Is alcohol: " + IsAlcohol + " Is milk: " + IsMilk + "Is ice: " + IsIce;
        }
    }

    class Food
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public bool IsItHot { get; set; }
    }

    class Soup : Food
    {

        public bool IsMeat { get; set; }
        public bool IsFish { get; set; }

        public Soup()
        {

        }
        public Soup(string name, string type, bool isithot, bool ismeat, bool isfish)
        {
            Name = name;
            IsItHot = isithot;
            IsMeat = ismeat;
            IsFish = isfish;
            Type = type;

        }
        public string Info()
        {
            return "Name: " + Name + " Type: " + Type + " Is it hot: " + IsItHot + " Is meat: " + IsMeat + " Is fish: " + IsFish;
        }
    }

    class MainDish : Food
    {
        public bool IsMeat { get; set; }
        public bool IsFish { get; set; }
        public string SideDish { get; set; }

        public MainDish()
        {

        }
        public MainDish(string name, string type, bool isithot, bool ismeat, bool isfish, string sidedish)
        {
            Name = name;
            Type = type;
            IsItHot = isithot;
            IsMeat = ismeat;
            IsFish = isfish;
            SideDish = sidedish;

        }
        public string Info()
        {
            return "Name: " + Name + " Type: " + Type + " Is it hot: " + IsItHot + " Is meat: " + IsMeat + " Is fish: " + IsFish + " Sidedish: " + SideDish;
        }
    }

    class Dessert : Food
    {
        public string Taste { get; set; }

        public Dessert()
        {

        }
        public Dessert(string name, string type, bool isithot, string taste)
        {
            Name = name;
            Type = type;
            IsItHot = isithot;
            Taste = taste;

        }
        public string Info()
        {
            return "Name: " + " Type: " + Type + Name + " Is it hot: " + IsItHot + " Taste: " + Taste;
        }
    }
}
