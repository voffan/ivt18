using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grades {

    class School {
        private String name;
        private String adress;
        private String email;
        private int phonenumber;

        public System.Collections.ArrayList class;

        /// <summary>
        /// Property for collection of Class
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.ArrayList Class
        {
            get {
                if (class == null) class = new System.Collections.ArrayList();
                return class;
            }
            set {
                RemoveAllClass();
                if (value != null) {
                    foreach(Class oClass in value)
                    AddClass(oClass);
                }
            }
        }

        /// <summary>
        /// Add a new Class in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddClass(Class newClass) {
            if (newClass == null) return;
            if (this.class == null) this.class = new System.Collections.ArrayList();
            if (!this.class.Contains(newClass)) this.class.Add(newClass);
        }

        /// <summary>
        /// Remove an existing Class from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemoveClass(Class oldClass) {
            if (oldClass == null) return;
            if (this.class != null) if (this.class.Contains(oldClass)) this.class.Remove(oldClass);
        }

        /// <summary>
        /// Remove all instances of Class from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllClass() {
            if (class != null) class.Clear();
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