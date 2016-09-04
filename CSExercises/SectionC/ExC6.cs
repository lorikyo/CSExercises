using System;

namespace CSExercises
{
    //Electrifying Electronics Pte Ltd. manufactures 
    //three audio-visual electronic products named 
    //as TV, DVD, and MP3.  The table below gives 
    //the unit price for each of these products:

    //PRODUCT   PRICE
    //TV	    $900
    //DVD	    $500
    //MP3	    $700

    //Retailers make orders for these products. 
    //Each order will have the product code and quantity 
    //(only one product in an order).  The company has a policy 
    //that discount of 10% is given when the order amount exceeds 
    //$5000 and 15% discount when the order amount exceeds $10000.  
    //These discounts apply to TV and DVD only and no discount is provided for MP3.

    //Write a program that would prompt the user successively 
    //the three product codes viz., TV, DVD, MP3 and after each prompt, 
    //the user enters the order quantity for that product.  
    //Then apply the price computations.  (Obviously, if the user does not 
    //wish to order the item prompted he/she would enter a zero for the order quantity).

    public class ExC6
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE - get user input, call the function and return the discounted price
            Console.Write("how many TV: ");
            int tvQty = Convert.ToInt32(Console.ReadLine());
            Console.Write("how many DVD: ");
            int dvdQty = Convert.ToInt32(Console.ReadLine());
            Console.Write("how many MP3: ");
            int mp3Qty = Convert.ToInt32(Console.ReadLine());
            double price = CalculateTotalPrice(tvQty, dvdQty, mp3Qty);
            Console.WriteLine(price);
        }

        public static double CalculateTotalPrice(int tvQty, int dvdQty, int mp3Qty)
        {
            //YOUR CODE HERE
            double totalPrice;
            double tvPrice = tvQty * 900;
            double dvdPrice = dvdQty * 500;
            double mp3Price = mp3Qty * 700;
            if (tvPrice > 5000)
                if (tvPrice > 10000)
                    tvPrice = tvPrice * (1 - 0.15);
                else
                    tvPrice = tvPrice * (1 - 0.10);
            //Console.WriteLine(tvPrice);
            if (dvdPrice > 5000)
                if (dvdPrice > 10000)
                    dvdPrice = dvdPrice * (1 - 0.15);
                else
                    dvdPrice = dvdPrice * (1 - 0.10);
            //Console.WriteLine(dvdPrice);
            totalPrice = tvPrice + dvdPrice + mp3Price;
            return totalPrice;
        }
    }
}