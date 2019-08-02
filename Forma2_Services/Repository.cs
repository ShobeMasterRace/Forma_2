using System;
using System.Collections.Generic;
using System.Linq;

namespace Forma2_Services
{
    public class Repository<T> where T : Forma2_Data.Models.IdModel
    {
        private Forma2_Data.Models.Context Kontekst;



        public T Get(int id)
        {
            T clanovi = Kontekst.Set<T>().FirstOrDefault(a => a.Id == id);

            return clanovi;


        }

        public List<T> GetAll()
        {
            List<T> clanovi = Kontekst.Set<T>().ToList();

            return clanovi;


        }        

        public T Add(T item)
        {
            Kontekst.Set<T>().Add(item);
            Kontekst.SaveChanges();

            return item;


        }

        //Edit, Delete
    }
}
