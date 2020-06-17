using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.CRUD
{
    public class Edit
    {
        /// <summary>
        /// Represent a method for editing client data
        /// </summary>
        /// <param name="_Id">Represent the id (int) of the client</param>
        /// <param name="_Name">Represnet the name (string) of the client</param>
        /// <param name="_Address">Represnet the address (string) of the client</param>
        /// <param name="_Cellphone">Represent the cellphone number (string) of the client</param>
        public void EditClient(int _Id, string _Name, string _Address, string _Cellphone)
        {
            //Represent a object of VikingRejser called context
            VikingRejserEntities context = new VikingRejserEntities();

            Kunder client = context.Kunders.First(i => i.Id == _Id);

            //Represent the name (string) of the client
            client.Navn = _Name;

            //Represnet the address (string) of the client
            client.Adresse = _Address;

            //Represent the cellphone number (string) of the client
            client.Telefon = _Cellphone;

           

            context.SaveChanges();
        } 
    }
}
