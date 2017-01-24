﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class Game
    {
        List<int> numbers;
        int expectedResult;
        int Score { get; set; }
        int nbrPlus;
        int nbrMoins;
        int nbrDivide;
        int nbrMulti;

        public Game(List<int> numbers, int result)
        {
            this.numbers = numbers;
            this.expectedResult = result;
            this.Score = 0;
            this.nbrPlus = 0;
            this.nbrMoins = 0;
            this.nbrDivide = 0;
            this.nbrMulti = 0;
        }

        public int Operation(int number1, int number2, char operateur)
        {
            int result = -1;
            switch (operateur){
                case '+':
                    result =  number1+number2;
                    nbrPlus++;
                    break;
                case '*':
                    result = number1 * number2;
                    nbrMulti++;
                    break;
                case '-':
                    if (number1 - number2 < 0)
                    {
                        break;
                    }
                        result = number1 - number2;
                    nbrMoins++;
                    break;
                case '/':
                    if (number1 % number2 != 0)
                    {
                        break;
                    }
                    result = number1 - number2;
                    nbrDivide++;
                    break;
            }
            return result;
        }

        public void UpdateScore()
        {
            if (nbrPlus == 1 && nbrMulti == 1 && nbrMoins == 1 && nbrDivide == 1)
            {
                Score = 13;
            }
            else
            {
                Score = nbrPlus + nbrMoins * 2 + nbrDivide * 3 + nbrMulti;
            }
            nbrDivide = 0;
            nbrMoins = 0;
            nbrMulti = 0;
            nbrPlus = 0;
        }

        public bool EndGame(int result)
        {
            bool isTerminated = false;
            if (result == this.expectedResult)
            {
                UpdateScore();
                isTerminated = true;
            }
            return isTerminated;
        }
    }

}
