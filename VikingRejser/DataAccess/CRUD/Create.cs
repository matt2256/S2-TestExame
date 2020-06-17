using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.Entity;
using System.Data;

namespace DataAccess.CRUD
{
    public class Create
    {
        /// <summary>
        /// Represent a method for creating Kunder data
        /// </summary>
        /// <param name="_Name">Represent the name (string) of the client</param>
        /// <param name="_Address">Represent the adress (string) of the client</param>
        /// <param name="_Cellphone">Represent the cellphone number (string) of the clien</param>
        /// <param name="_TravelArragement">Represent the TravelArragement (string) of the client</param>
        public void CreateClient(string _Name, string _Address, string _Cellphone, string _TravelArragement)
        {
            //Represent a object of VikingRejserEntities called context
            VikingRejserEntities context = new VikingRejserEntities();

            Kunder client = new Kunder()
            {
                //Represent the name (string) of the client
                Navn = _Name,

                //Represent the adress (string) of the client
                Adresse = _Address,

                //Represent the cellphone number (string) of the client
                Telefon = _Cellphone,

                //Represent the TravelArragement (string) of the client
                RejseArrangementer = _TravelArragement
            };

            context.Kunders.Add(client);

            context.SaveChanges();
        }
    }
}
