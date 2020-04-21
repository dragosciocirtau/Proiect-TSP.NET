using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelAndAPI
{
    public class InsertIntoDB
    {
        public void insertPicture(Picture item)
        {
            using (Model1Container ct = new Model1Container())
            {
                var pics = from p in ct.Pictures select p.name;
                bool insertPic = true;
                for (int i = 0; i < pics.Count(); i++)
                {
                    if(pics.ElementAt(i) == item.name){
                        insertPic = false;
                    }
                }
                if (insertPic == true)
                {
                    ct.Database.ExecuteSqlCommand("insert values( @i0, @i1, @i2, @i3, @i4, @i5, @i6, @i7 ) into Pictures", item.name, item.type, item.path, item.creation_date, item.location, item.persons, item.@event, item.other_details);
                    ct.SaveChanges();
                }
            }
        }

        public void editPicture(Picture item)
        {
            using (Model1Container ct = new Model1Container())
            {
                Picture pic = ct.Pictures.Find(item.name);
                pic = item;
                ct.SaveChanges();
            }
        }

        public void addLocation(Location l)
        {
            using (Model1Container ct = new Model1Container())
            {
                ct.Database.ExecuteSqlCommand("insert values( @i0 ) into Locations", l.name);
                ct.SaveChanges();
            }
        }

        public void addEvent(Event e)
        {
            using (Model1Container ct = new Model1Container())
            {
                ct.Database.ExecuteSqlCommand("insert values( @i0 , @i1 ) into Events", e.Id, e.name);
                ct.SaveChanges();
            }
        }

        public void addPerson(Person p)
        {
            using (Model1Container ct = new Model1Container())
            {
                ct.Database.ExecuteSqlCommand("insert values( @i0 ) into Persons", p.name);
                ct.SaveChanges();
            }
        }
    }
}
