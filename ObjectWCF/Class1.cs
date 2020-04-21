using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelAndAPI;

namespace ObjectWCF
{
    public class Class1 : MyInterface
    {
        void InterfaceEvent.addEvent(Event e)
        {
            InsertIntoDB iidb = new InsertIntoDB();
            iidb.addEvent(e);
        }

        void InterfaceEvent.deleteEvent(Event e)
        {
            RetrieveFromDB rfdb = new RetrieveFromDB();
            rfdb.deleteEvent(e);
        }

        void InterfaceLocation.addLocation(Location l)
        {
            InsertIntoDB iidb = new InsertIntoDB();
            iidb.addLocation(l);
        }

        void InterfaceLocation.deleteLocation(Location l)
        {
            RetrieveFromDB rfdb = new RetrieveFromDB();
            rfdb.deleteLocation(l);
        }

        void InterfacePerson.addPerson(Person p)
        {
            InsertIntoDB iidb = new InsertIntoDB();
            iidb.addPerson(p);
        }

        void InterfacePerson.deletePerson(Person p)
        {
            RetrieveFromDB rfdb = new RetrieveFromDB();
            rfdb.deletePerson(p);
        }

        void InterfacePicture.deletePicture(Picture p)
        {
            RetrieveFromDB rfdb = new RetrieveFromDB();
            rfdb.deletePicture(p);
        }

        Picture InterfacePicture.getPicture(int name)
        {
            RetrieveFromDB rfdb = new RetrieveFromDB();
            return rfdb.getPicture(name);
        }

        List<Picture> InterfacePicture.getPictures(string query)
        {
            RetrieveFromDB rfdb = new RetrieveFromDB();
            return rfdb.getPictures(query);
        }

        void InterfacePicture.insertPicture(Picture p)
        {
            InsertIntoDB iidb = new InsertIntoDB();
            iidb.insertPicture(p);
        }

        void InterfacePicture.updatePicture(Picture p)
        {
            InsertIntoDB iidb = new InsertIntoDB();
            iidb.editPicture(p);
        }
    }
}
