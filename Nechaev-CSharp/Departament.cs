using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Worker_namespace;

namespace Departament_namespace
{
    public class Departament
    {
        private string name;
        private List<Worker> workers;
        public Departament(string name)
        {
            workers = new List<Worker> { };
            this.name = name;
        }
        public string Name { get { return name; } }
        public bool AddWorker(Worker worker)
        {
            workers.Add(worker);
            worker.Departament = this;
            return true;
        }
        public bool FireWorker(Worker workerToFire)
        {
            foreach (Worker worker in workers)
            {
                if (workerToFire == worker)
                {
                    workers.Remove(worker);
                    return true;
                }
            }
            return false;
        }
        public void PrintWorkers()
        {
            foreach(Worker worker in workers)
            {
                worker.PrintInfo();
            }
        }
    }
}
