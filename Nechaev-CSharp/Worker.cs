using System;
using System.Collections.Generic;
using System.Text;
using Departament_namespace;

namespace Worker_namespace
{
    public class Worker
    {
        private string name;
        private int bet;
        private int selary;
        private int workHours;
        private Departament departament;
        public Worker(string name, int bet, int workHours)
        {
            this.name = name;
            this.bet = bet;
            this.workHours = workHours;
            SetSelary();
        }
        public Departament Departament
        {
            set { departament = value; }
        }
        public void PrintInfo() => Console.WriteLine($"Работник {name} со ставкой {bet}, зарплатой {selary}, рабочими часами {workHours} из депортамента {departament.Name}");
        public void SetSelary() => selary = bet * workHours;
    }
}
