using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data
{
    public class GroupCRUD
    {
        private List<Group> GroupTable; 
        public GroupCRUD()
        {
            GroupTable = new List<Group>();
        }
        
        public List<Group> GetStudent()
        {
          
            return GroupTable;

        }

        public Group CreateGroup(string id, string GroupName, int AvailableGroup)
        {
            Group Nuevo = new Group()
            {
                ID = id,
                Name = GroupName,
                AvailableSlots = AvailableGroup
            };
            GroupTable.Add(Nuevo);

            return Nuevo;
        }


        public Group UpdateStudent(Group AModificar, string id, string GroupName, int AvailableGroup)
        {
            AModificar.ID = id;
            AModificar.Name = GroupName;
            AModificar.AvailableSlots = AvailableGroup;
            return AModificar;
        }

        public Group DeleteStudent( Group grupo)
        {

            return grupo;
        }
    }
}
