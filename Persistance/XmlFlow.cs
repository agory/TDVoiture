using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Metier;

namespace Persistance
{
    public class XmlFlow
    {
        private string chemin;


        public Agence importerAgence()
        {
            Agence agence = null;
            FileStream stream = null;
            XmlSerializer serializer;
            if (File.Exists(chemin))
            {
                try
                {
                    stream = new FileStream(chemin, FileMode.Open, FileAccess.Read);
                    serializer = new XmlSerializer(typeof(Agence));
                    agence = (Agence)serializer.Deserialize(stream);
                    stream.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    stream.Close();
                }
            }
            return agence;
        }

        public void exporterAgence(Agence agence) {
            FileStream stream = null;
            XmlSerializer serializer;
            try
            {
                stream = new FileStream(chemin, FileMode.Create);
                serializer = new XmlSerializer(typeof(Agence));
                serializer.Serialize(stream, agence);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                stream.Close();
            }
            
        }


        public XmlFlow(string chemin)
        {
            this.chemin = chemin;
        }



    }

}
