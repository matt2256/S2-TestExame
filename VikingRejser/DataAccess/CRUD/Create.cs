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
        /// <param name="_name">Represent the name (string) of the client</param>
        /// <param name="_address">Represent the adress (string) of the client</param>
        /// <param name="_cellphone">Represent the cellphone number (string) of the clien</param>
        public void CreateClient(string _name, string _address, string _cellphone)
        {
            //Represent a object of VikingRejserEntities called context
            VikingRejserEntities context = new VikingRejserEntities();

            Kunder client = new Kunder()
            {
                //Represent the Navn (string) of the client
                Navn = _name,

                //Represent the Adresse (string) of the client
                Adresse = _address,

                //Represent the Telefon (string) of the client
                Telefon = _cellphone,
            };

            context.Kunders.Add(client);

            context.SaveChanges();
        }

        /// <summary>
        /// Represent a method for creating travel data
        /// </summary>
        /// <param name="_title">Represent the Title (string) of the travel</param>
        /// <param name="_city">Represent the By (string) of the travel</param>
        /// <param name="_startDate">Represent the Startdato (datetime) of the travel</param>
        /// <param name="_endDate">Represent the Slutdato (datetime) of the travel</param>
        /// <param name="_price">Represent the Pris (int) of the travel</param>
        /// <param name="_maxparticipant">Represent the MaxAntal (string) of the travel</param>
        /// <param name="_describtion">Represent the Beskrivelse (string) of the travel</param>
        public void CreateTravel(string _title, string _city, DateTime _startDate, DateTime _endDate, int _price, string _maxparticipant, string _describtion)
        {
            //Represent a object of VikingRejserEntities called _context
            VikingRejserEntities _context = new VikingRejserEntities();

            Rejsearrangementer _travel = new Rejsearrangementer
            {
                //Represent the Title (string) of the travel
                Title = _title,

                //Represent the By (string) of the travel
                By = _city,

                //Represent the Startdato (datetime) of the travel
                Stardato = _startDate,

                //Represent the Slutdato (datetime) of the travel
                Slutdato = _endDate,

                //Represent the Pris (int) of the travel
                Pris = _price,

                //Represent the MaxAntal (string) of the travel
                MaxAntal = _maxparticipant,

                //Represent the Beskrivelse (string) of the travel
                Beskrivelse = _describtion
            };

            _context.Rejsearrangementers.Add(_travel);

            _context.SaveChanges();
        }
    }
}
