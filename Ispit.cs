using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba_za_ocijenu
{
    public class FoodType
    {
        private String name;
        private int protein; // postotak proteina
        private int carbs;   // postotak ugljikohidrata
        private int fat;     // postotak masti
        private static int counter = 0;

        // Konstruktor koji prima sve vrijednosti za atribute
        public FoodType(String name, int protein, int carbs, int fat)
        {
            this.name = name;
            this.protein = protein;
            this.carbs = carbs;
            this.fat = fat;
            counter++; // Povećava broj kreiranih objekata prilikom svakog poziva konstruktora
        }

        // Getteri za svaki atribut
        public String getName()
        {
            return name;
        }

        public int getProtein()
        {
            return protein;
        }

        public int getCarbs()
        {
            return carbs;
        }

        public int getFat()
        {
            return fat;
        }

        // Metoda toString koja predstavlja objekt u zadatom formatu
        public String toString()
        {
            return name + ": p - " + protein + "%, c - " + carbs + "%, f - " + fat + "%";
        }

        // Statička metoda koja vraća broj kreiranih objekata
        public static int getNumberOfCreatedInstances()
        {
            return counter;
        }
    }

    public class Food
    {
        private FoodType type;
        private int weight; // Težina u gramima

        // Konstruktor koji prima objekt tipa FoodType i težinu
        public Food(FoodType type, int weight)
        {
            this.type = type;
            this.weight = weight;
        }

        // Getteri za type i weight
        public FoodType getType()
        {
            return type;
        }

        public int getWeight()
        {
            return weight;
        }

        // Getteri za protein, carbs i fat u gramima
        public double getProtein()
        {
            return (type.getProtein() / 100.0) * weight;
        }

        public double getCarbs()
        {
            return (type.getCarbs() / 100.0) * weight;
        }

        public double getFat()
        {
            return (type.getFat() / 100.0) * weight;
        }

        // Metoda toString koja predstavlja objekt u zadatom formatu
        public String toString()
        {
            return type.toString() + ", w - " + weight + "g";
        }

        // Metoda koja predstavlja objekt u gramima
        public String toStringInGrams()
        {
            return type.getName() + ": p - " + String.format("%.1f", getProtein()) + "g, c - "
                    + String.format("%.1f", getCarbs()) + "g, f - " + String.format("%.1f", getFat())
                    + "g, w - " + weight + "g";
        }

        public static void main(String[] args)
        {
            FoodType foodType = new FoodType("banana", 4, 93, 3);
            Food food = new Food(foodType, 110);

            // Testiranje ispisivanja informacija o hrani
            System.out.println(foodType.toString());
            System.out.println(food.toString());
            System.out.println(food.toStringInGrams());

            // Testiranje broja kreiranih objekata
            System.out.println("Number of created instances: " + FoodType.getNumberOfCreatedInstances());
        }
    }
}
