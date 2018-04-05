﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class Books:IComparable<Books>
    {
        #region Properties

        public string ISBN { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public int Pagesquantity {
            get { return Pagesquantity; }
            set
            { if (value < 1) throw new Exception("The quantity of pages can't be lower than 1");
                else Pagesquantity = value; }
        }
        public decimal Price { get { return Price; }
            set { if (Price < 0) throw new Exception("The price can't be lower than 0");
                else Price = value;
            }
        }
        #endregion
        #region Constructors
        public Books(string ISBN, string author, string name,string publisher,int year, int pagesquantity, decimal price)
        {
            this.ISBN = ISBN;
            Author = author;
            Name = name;
            Publisher = publisher;
            Year = year;
            Pagesquantity = pagesquantity;
            Price = price;
        }

        #endregion
        #region Override
        public override bool Equals(object otherbook)
        {
            if (ReferenceEquals(this, otherbook)) return true;
            if (ReferenceEquals(otherbook, null)) return false;
            if (otherbook.GetType() != this.GetType()) return false;
            Books newotherbook = otherbook as Books;
            if (this.ISBN == newotherbook.ISBN && this.Author == newotherbook.Author && this.Name == newotherbook.Name && this.Publisher == newotherbook.Publisher && this.Pagesquantity == newotherbook.Pagesquantity && this.Price == newotherbook.Price) return true;
            else return false;
        }

        public override int GetHashCode()
        {
            return this.ISBN.GetHashCode();
        }

        public override string ToString()
        {
            if (String.IsNullOrEmpty(ISBN)||String.IsNullOrEmpty(Author)||String.IsNullOrEmpty(Name)||String.IsNullOrEmpty(Publisher)) return base.ToString();
            return (ISBN+Author+Name+Publisher+Year+Pagesquantity.ToString()+Price.ToString());
        }

        public int CompareTo(Books other)
        {
            if (other == null) return 1;
            int result = string.Compare(ISBN, other.ISBN);
            if (result != 0) return result;
            result = string.Compare(Author,other.Author);
            if (result != 0) return result;
            result = string.Compare(Name, other.Name);
            if (result != 0) return result;
            result = string.Compare(Publisher, other.Publisher);
            if (result != 0) return result;
            result=ISBN.CompareTo(other.ISBN);
            if (result != 0) return result;
            result = Year.CompareTo(other.Year);
            if (result != 0) return result;
            result = Pagesquantity.CompareTo(other.Pagesquantity);
            if (result != 0) return result;
            return Price.CompareTo(other.Price);
           
         }


    }

    


}

