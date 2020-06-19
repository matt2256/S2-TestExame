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
        public void EditClient(int _Id,string _Name, string _Address, string _Cellphone)
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

        /// <summary>
        /// Represent a method for editing travel data 
        /// </summary>
        /// <param name="_id">Represnt the unique id (int) of each travel</param>
        /// <param name="_title">Represent the Title (string) of the travel</param>
        /// <param name="_city">Represent the By (string) of the travel</param>
        /// <param name="_startDate">Represent the Startdato (datetime) of the travel</param>
        /// <param name="_endDate">Represent the Slutdato (datetime) of the travel</param>
        /// <param name="_price">Represent the Pris (int) of the travel</param>
        /// <param name="_maxparticipant">Represent the MaxAntal (string) of the travel</param>
        /// <param name="_describtion">Represent the Beskrivelse (string) of the travel</param>
        public void EditTravel(int _id,string _title, string _city, DateTime _startDate, DateTime _endDate, int _price, string _maxparticipant, string _describtion)
        {
            //Represent a object of VikingRejserEntities called _context
            VikingRejserEntities context = new VikingRejserEntities();

            Rejsearrangementer travel = context.Rejsearrangementers.First(i => i.Id == _id);

            //Represent the Title (string) of the travel
            travel.Title = _title;

            //Represent the By (string) of the travel
            travel.By = _city;

            //Represent the Startdato (datetime) of the travel
            travel.Stardato = _startDate;

            //Represent the Slutdato (datetime) of the travel
            travel.Slutdato = _endDate;

            //Represent the Pris (int) of the travel
            travel.Pris = _price;

            //Represent the MaxAntal (string) of the travel
            travel.MaxAntal = _maxparticipant;

            //Represent the Beskrivelse (string) of the travel
            travel.Beskrivelse = _describtion;

            context.SaveChanges();
            
        }
    }
}
