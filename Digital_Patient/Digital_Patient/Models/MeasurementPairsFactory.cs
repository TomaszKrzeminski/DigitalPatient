using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digital_Patient.Models
{


    public interface IMeasurementPair
    {
        List<MeasurementPair> AddPairs();
    }

    public enum MeasurementCat
    {
        Ciśnienie, Waga, Saturacja, Temperatura, Ekg,Czas,Stan,Ilość,Uwaga,Kalorie
    }

    public class Ciśnienie : IMeasurementPair
    {
        public List<MeasurementPair> AddPairs()
        {
            return new List<MeasurementPair>() {new MeasurementPair("Sys mmhg", false),new MeasurementPair("Dia mmhg", false),new MeasurementPair("pul/min",false) };
        }

       
    }
    public class Waga : IMeasurementPair
    {
        public List<MeasurementPair> AddPairs()
        {
            return new List<MeasurementPair>() {new MeasurementPair("kg",false) };
        }


    }
    public class Temperatura : IMeasurementPair
    {
        public List<MeasurementPair> AddPairs()
        {
            return new List<MeasurementPair>() {new MeasurementPair("temp C",false) };
        }


    }
    public class Saturacja : IMeasurementPair
    {
        public List<MeasurementPair> AddPairs()
        {
            return new List<MeasurementPair>() {new MeasurementPair("Puls",false),new MeasurementPair("SpO2%" ,false) };
        }


    }
    public class Ekg : IMeasurementPair
    {
        public List<MeasurementPair> AddPairs()
        {
            return new List<MeasurementPair>() {new MeasurementPair("Zespół QRS",false),new MeasurementPair("Załamek T",false),new MeasurementPair("Odcinki i odstępy") };
        }


    }

    public class Czas : IMeasurementPair
    {
        public List<MeasurementPair> AddPairs()
        {
            return new List<MeasurementPair>() { new MeasurementPair("min",false) };
        }


    }

    public enum StanPacjenta
    {
        lekki,średnio_ciężki,bardzo_ciężki


    }


    public class Stan : IMeasurementPair
    {
        public List<MeasurementPair> AddPairs()
        {
            return new List<MeasurementPair>() {new MeasurementPair("Stan") };
        }


    }

    public class Ilość : IMeasurementPair
    {
        public List<MeasurementPair> AddPairs()
        {
            return new List<MeasurementPair>() {new MeasurementPair("Ilość",false) };
        }


    }

    public class Uwaga : IMeasurementPair
    {
        public List<MeasurementPair> AddPairs()
        {
            return new List<MeasurementPair> {new MeasurementPair("Uwaga",true ) };
        }


    }

    public class Kalorie : IMeasurementPair
    {
        public List<MeasurementPair> AddPairs()
        {
            return new List<MeasurementPair>() {new MeasurementPair("kcal",false) };
        }


    }
   

    public class MeasurementPairsFactory
    {
        public IMeasurementPair mp { get; set; }

        public virtual IMeasurementPair SetTaskCat(MeasurementCat cat)
        {
            switch (cat)
            {      
                case MeasurementCat.Ciśnienie:
                    mp = new Ciśnienie();
                    break;
                case MeasurementCat.Waga:
                    mp = new Waga();
                    break;
                case MeasurementCat.Saturacja:
                    mp = new Saturacja();
                    break;
                case MeasurementCat.Temperatura:
                    mp = new Temperatura();
                    break;
                case MeasurementCat.Ekg:
                    mp = new Ekg();
                    break;
                case MeasurementCat.Czas:
                    mp = new Czas();
                    break;

                case MeasurementCat.Stan:
                    mp = new Stan();
                    break;               

                case MeasurementCat.Ilość:
                    mp = new Ilość();
                    break;

                case MeasurementCat.Uwaga:
                    mp = new Uwaga();
            break;
            case MeasurementCat.Kalorie:
                    mp = new Kalorie();
            break;
            default:
                    break;
            }
            return mp;
        }


    }





    public class MeasurementPairSelector
    {
        IMeasurementPair mPair = null;

        public Measurement AddMeasurementPairToMeasurement(MeasurementCat cat, Measurement measurement)
        {
            MeasurementPairsFactory factory = new MeasurementPairsFactory();
            IMeasurementPair mPair = factory.SetTaskCat(cat);
            List<MeasurementPair> categories = mPair.AddPairs();
            List<Measurement> measurementList = new List<Measurement>();

            measurement.MeasurementPairs.AddRange(categories);
            
            return measurement;
        }
    }








}




