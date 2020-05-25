using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelAndAPI
{
    public class RetrieveFromDB
    {
        public List<Picture> getPictures(string keyword)
        {
            using (Model1Container ct = new Model1Container())
            {
                List<Picture> lp = new List<Picture>();
                var items = from p in ct.Pictures where (p.@event.Contains(keyword) || p.location.Contains(keyword) || p.other_details.Contains(keyword) || p.persons.Contains(keyword)) select p;
                if (items != null) {
                    for (int i = 0; i < items.Count(); i++)
                    {
                        //lp.OrderBy(picture => picture.name);
                        lp.Add(items.OrderBy(picture => picture.name).Skip(i).First());
                    }
                }

                return lp;
            }

        }

        public Picture getPicture(int id)
        {
            using (Model1Container ct = new Model1Container())
            {
                var pic = from p in ct.Pictures where (p.name == id) select p;
                return pic.ElementAt(0);
            }
            //Picture p = new Picture();

        }

        public void deletePicture(Picture item)
        {
            using (Model1Container ct = new Model1Container())
            {
                ct.Database.ExecuteSqlCommand("Delete From Pictures where name =@p0", item.name);
            }
        }

        public void deleteEvent(Event e)
        {
            using (Model1Container ct = new Model1Container())
            {
                ct.Database.ExecuteSqlCommand("Delete From Events where Id =@p0", e.Id);
            }
        }

        public void deleteLocation(Location l)
        {
            using (Model1Container ct = new Model1Container())
            {
                ct.Database.ExecuteSqlCommand("Delete From Locations where name =@p0", l.name);
            }
        }

        public void deletePerson(Person p)
        {
            using (Model1Container ct = new Model1Container())
            {
                ct.Database.ExecuteSqlCommand("Delete From Persons where name =@p0", p.name);
            }
        }
    }
}
