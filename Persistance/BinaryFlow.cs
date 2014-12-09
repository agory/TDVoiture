using Metier;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    public class BinaryFlow
    {
        private string chemin;


        public Agence importerAgence()
        {
            Agence agence = null;
            FileStream unFlux = null;
            try
            {
                BinaryFormatter fs;
                //On ouvre un flux binaire
                unFlux = new FileStream(chemin, FileMode.Open);
                //On formate le flux en binaire
                fs = new BinaryFormatter();
                //On vide la collection avant de récupérer le contenu désérialiser
                agence = (Agence)fs.Deserialize(unFlux);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                unFlux.Close();
            }
            return agence;
        }

        public void exporterAgence(Agence agence)
        {
            FileStream unFlux = null;
            BinaryFormatter fs;

            try
            {

                unFlux = new FileStream(chemin, FileMode.Create);
                //On formate le flux en binaire
                fs = new BinaryFormatter();
                fs.Serialize(unFlux, agence);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                unFlux.Close();
            }

        }


        public BinaryFlow(string chemin)
        {
            this.chemin = chemin;
        }




    }
}
