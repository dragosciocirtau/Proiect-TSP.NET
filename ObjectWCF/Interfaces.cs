using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

using ModelAndAPI;

namespace ObjectWCF
{
    [ServiceContract]
    interface InterfaceEvent
    {
        [OperationContract]
        void deleteEvent(Event e);

        [OperationContract]
        void addEvent(Event e);


    }

    [ServiceContract]
    interface InterfacePerson
    {
        [OperationContract]
        void deletePerson(Person p);

        [OperationContract]
        void addPerson(Person p);
    }

    [ServiceContract]
    interface InterfaceLocation
    {
        [OperationContract]
        void deleteLocation(Location l);

        [OperationContract]
        void addLocation(Location l);
    }

    [ServiceContract]
    interface InterfacePicture
    {
        [OperationContract]
        void insertPicture(Picture p);

        [OperationContract]
        void deletePicture(Picture p);

        [OperationContract]
        void updatePicture(Picture p);

        [OperationContract]
        Picture getPicture(int name);

        [OperationContract]
        List<Picture> getPictures(string query);
    }

    [ServiceContract]
    interface MyInterface : InterfaceEvent, InterfaceLocation, InterfacePerson, InterfacePicture { }
}
