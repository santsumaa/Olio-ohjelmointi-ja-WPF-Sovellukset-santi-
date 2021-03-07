using System;
using System.Collections.Generic;
using System.Text;

// Täytyy olla, kun halutaan käyttää tiedostoon kirjoittamista & serialisointia
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Harjoituts_20__WPF_
{
    static class KokoelmaManageri
    {
        private static string path = "OpiskelijaKokoelma.bin";

        public static Dictionary<string, Opiskelija> Opiskelijat = new Dictionary<string, Opiskelija>();

        public static void LisääOpiskelija(string etunimi, string sukunimi, string opiskelijaID)
        {
            Opiskelijat.Add(opiskelijaID, new Opiskelija(etunimi, sukunimi, opiskelijaID));
        }

        public static bool TarkistaID(string id)
        {
            if (Opiskelijat.ContainsKey(id))
            {
                throw new OpiskelijaPoikkeus("OpiskelijaID " + id + " ei ole uniikki, anna uusi ID");
            }
            else
            {
                return true;
            }
        }
        
        /// <summary>
        /// Poistetaan opiskelija sanakirjasta annetun indexin avulla.
        /// </summary>
        /// <param name="index"></param>
        public static void PoistaOpiskelija(Opiskelija opiskelija)
        {
            Opiskelijat.Remove(opiskelija.OpiskelijaID);
        }

        public static List<Opiskelija> PalautaOpiskelijat()
        {
            List<Opiskelija> opiskelijatListassa = new List<Opiskelija>();

            opiskelijatListassa.AddRange(Opiskelijat.Values);

            return opiskelijatListassa;
        }

        public static string LoadFromFile()
        {
            Stream fileStream = null;
            string result = "";

            try
            {
                fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None);
                IFormatter formatter = new BinaryFormatter();


                List<Opiskelija> opiskelijatList = (List<Opiskelija>)formatter.Deserialize(fileStream);

                foreach (Opiskelija op in opiskelijatList)
                {
                    Opiskelijat.Add(op.OpiskelijaID, op);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                result = ex.Message;
            }

            return result;
        }

        public static string SaveToFile()
        {
            Stream fileStream = null;
            string result = "";

            try
            {
                fileStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
                IFormatter formatter = new BinaryFormatter();

                List<Opiskelija> opiskelijatList = new List<Opiskelija>();

                foreach (Opiskelija op in Opiskelijat.Values)
                {
                    opiskelijatList.Add(op);
                }

                formatter.Serialize(fileStream, opiskelijatList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                result = ex.Message;
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }

            return result;
        }
    }
}
