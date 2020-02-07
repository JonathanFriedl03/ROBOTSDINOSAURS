﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsDinosaurs
{
    class BattlefieldScore
    {
    }
}



class Game
{
    //Member Variables -(Relationship defines "Has A"...Property/Trait) Declares variables that can be accessed anywhere in this class
    int playerOneScore;
    int playerTwoScore;
    Random rnd = new Random();

    //Constructor -(Relationship Defines "Spawner/Instantiate/Create"...) Sets the scores to 0 when a new game is created
    public Game()
    {
        playerOneScore = 0;
        playerTwoScore = 0;
    }
    //Don't change anything above this ^^^^^^^^^^^^

    //Member Methods -(Relationship the Method "Can Do"...)All your methods go below here!
    public int RollDice()
    {
        int result;


        result = rnd.Next(1, 7);

        return result;


    }

    public void CompareRolls(int playerOneRoll, int playerTwoRoll)
    {
        if (playerOneRoll > playerTwoRoll)
        {
            playerOneScore++;
            Console.WriteLine("Player One's Score is " + playerOneScore + " Player One Wins This Round!");

        }

        else if (playerTwoRoll > playerOneRoll)
        {
            playerTwoScore++;
            Console.WriteLine("Player Two's Score is " + playerTwoScore + " Player Two Wins This Round!");


        }

        else
        {
            Console.WriteLine("Tie! Roll Again Players!");
            RollDice();
        }


    }

    public void DisplayGameWinner()
    {
        if (playerOneScore == 3)
            Console.WriteLine("Player One Wins This Round and the Game!");
        else if (playerTwoScore == 3)
            Console.WriteLine("Player Two Wins This Round and the Game!");

    }

    //This is the main method that is called in the Program when you press Start
    //Call your other methods inside this method
    public void RunGame()
    {

        while (playerOneScore < 3 && playerTwoScore < 3) // round loop
        {

            int playerOneRoll = RollDice();
            Console.WriteLine("Player One's Roll is " + playerOneRoll);
            int playerTwoRoll = RollDice();
            Console.WriteLine("Player Two's Roll is " + playerTwoRoll);
            CompareRolls(playerOneRoll, playerTwoRoll);


        }

        DisplayGameWinner();


        Console.WriteLine("Wanna Play Again?");
        Console.ReadLine();

