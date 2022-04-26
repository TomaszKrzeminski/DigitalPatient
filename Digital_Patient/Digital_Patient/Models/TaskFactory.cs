using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Digital_Patient.Data;
using Digital_Patient.Models;

namespace Digital_Patient.Models
{


    public class MeasurementCategoryFactory
    {   
        public ITaskCat taskCat = null;
        public virtual ITaskCat SetTaskCat(TaskCat cat)
        {           
         switch (cat)
            {
                case TaskCat.Stolec:
                    taskCat = new Stolec();
                    break;
                case TaskCat.Jedzenie:
                    taskCat = new Jedzenie();
                    break;
                case TaskCat.Lekarstwo:
                    taskCat = new Lekarstwo();
                    break;
                case TaskCat.Mocz:
                    taskCat = new Mocz();
                    break;
                case TaskCat.Płyn:
                    taskCat = new Płyn();
                    break;
                case TaskCat.Ćwiczenia:
                    taskCat = new Ćwiczenia();
                    break;
               default:
                break;
            }
            return taskCat;
        }



    

}

    public enum TaskCat
    {
        Stolec, Mocz, Lekarstwo, Płyn, Jedzenie, Ćwiczenia
    }

    //public enum MeasurementCat
    //{
    //    Ciśnienie, Waga, Saturacja, Temperatura, Ekg,Czas,Stan,Ilość,Uwaga,Kalorie
    //}

   public  interface ITaskCat
    {         
         List<MeasurementCategory> AddCategories();
    }


    public class Stolec : ITaskCat
    {
        public List<MeasurementCategory> AddCategories()
        {
            return new List<MeasurementCategory>() {new MeasurementCategory(){CategoryName="Waga",pairType=PairType.numeric },new MeasurementCategory() {CategoryName="Uwaga",pairType=PairType.text } };
        }
       
    }

    public class Mocz : ITaskCat
    {
    public List<MeasurementCategory> AddCategories()
        {
            return new List<MeasurementCategory>() { new MeasurementCategory() { CategoryName = "Ilość",pairType=PairType.text }, new MeasurementCategory() { CategoryName = "Uwaga",pairType=PairType.text } };
        }
}

    public class Lekarstwo : ITaskCat
    {
    public List<MeasurementCategory> AddCategories()
        {
            return new List<MeasurementCategory>() { new MeasurementCategory() { CategoryName = "Ilość",pairType=PairType.numeric }, new MeasurementCategory() { CategoryName = "Uwaga",pairType=PairType.text } };
        }
   }

    public class Płyn : ITaskCat
    {
    public List<MeasurementCategory> AddCategories()
        {
            return new List<MeasurementCategory>() { new MeasurementCategory() { CategoryName = "Ilość",pairType=PairType.numeric }, new MeasurementCategory() { CategoryName = "Uwaga",pairType=PairType.text } };
        }
}

    public class Jedzenie : ITaskCat
    {
    public List<MeasurementCategory> AddCategories()
        {
            return new List<MeasurementCategory>() { new MeasurementCategory() { CategoryName = "Waga",pairType=PairType.numeric }, new MeasurementCategory() { CategoryName = "Uwaga",pairType=PairType.text } };
        }
}

    public class Ćwiczenia : ITaskCat
    {
    public List<MeasurementCategory> AddCategories()
        {
        return new List<MeasurementCategory>() { new MeasurementCategory() {CategoryName="Czas",pairType=PairType.text,PairsNumber=1},new MeasurementCategory() { CategoryName = "Ilość",pairType=PairType.numeric },new MeasurementCategory() {CategoryName="Kalorie" ,pairType=PairType.numeric} ,new MeasurementCategory() { CategoryName = "Ciśnienie",pairType=PairType.numeric },new MeasurementCategory() {CategoryName="Saturacja",pairType=PairType.numeric } };
    }
}




    public class MeasurementSelector
    {
        ITaskCat taskCat = null;
        
        public TaskToDo AddMeasurementToTask(TaskCat cat, TaskToDo taskTodo)
        {
            MeasurementCategoryFactory factory = new MeasurementCategoryFactory();
            ITaskCat tasktoDoCat = factory.SetTaskCat(cat);
            List<MeasurementCategory> categories = tasktoDoCat.AddCategories();
            List<Measurement> measurementList = new List<Measurement>();
            foreach (var mcat in categories)
            {
                Measurement measurement1 = new Measurement();
                measurement1.MeasurementCategory = mcat;
                measurementList.Add(measurement1);
            }          

            taskTodo.Measurements.AddRange(measurementList);
            return taskTodo;
        }
    }



}
