using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.CRUD
{
    public class Delete
    {
        /// <summary>
        /// Represent a method for deleting client data
        /// </summary>
        /// <param name="_Id">Represent the Id (int) of the client</param>
        public void DeleteClient(int _Id)
        {
            //Represent a object of VikingRejser called context
            VikingRejserEntities context = new VikingRejserEntities();

            Kunder client = context.Kunders.First(i => i.Id == _Id);

            context.Kunders.Remove(client);
        }
    }
}
