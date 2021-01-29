using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace grades {

    class School {
        private String name;
        private String adress;
        private String email;
        private int phonenumber;

        public System.Collections.ArrayList group;

        /// <summary>
        /// Property for collection of Class
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.ArrayList Group
        {
            get {
                if (group == null) group = new System.Collections.ArrayList();
                return group;
            }
            set {
                RemoveAllGroup();
                if (value != null) {
                    foreach(Group oGroup in value)
                    AddGroup(oGroup);
                }
            }
        }

        /// <summary>
        /// Add a new Class in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddGroup(Group newGroup) {
            if (newGroup == null) return;
            if (this.group == null) this.group = new System.Collections.ArrayList();
            if (!this.group.Contains(newGroup)) this.group.Add(newGroup);
        }

        /// <summary>
        /// Remove an existing Class from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemoveGroup(Group oldGroup) {
            if (oldGroup == null) return;
            if (this.group != null) if (this.group.Contains(oldGroup)) this.group.Remove(oldGroup);
        }

        /// <summary>
        /// Remove all instances of Class from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllGroup() {
            if (group != null) group.Clear();
        }

        public System.Collections.ArrayList staff;

        /// <summary>
        /// Property for collection of Staff
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.ArrayList Staff

        {
            get {
                if (staff == null) staff = new System.Collections.ArrayList();
                return staff;
            }
            set {
                RemoveAllStaff();
                if (value != null) {
                    foreach(Staff oStaff in value)
                    AddStaff(oStaff);
                }
            }
        }

        /// <summary>
        /// Add a new Staff in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddStaff(Staff newStaff) {
            if (newStaff == null) return;
            if (this.staff == null) this.staff = new System.Collections.ArrayList();
            if (!this.staff.Contains(newStaff)) this.staff.Add(newStaff);
        }

        /// <summary>
        /// Remove an existing Staff from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemoveStaff(Staff oldStaff) {
            if (oldStaff == null) return;
            if (this.staff != null) if (this.staff.Contains(oldStaff)) this.staff.Remove(oldStaff);
        }

        /// <summary>
        /// Remove all instances of Staff from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllStaff() {
            if (staff != null) staff.Clear();
        }

        public Staff headteacher;
    }
}