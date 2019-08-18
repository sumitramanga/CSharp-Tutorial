using System;
namespace cstutorial
{
    class Staff
    {
        public string staffName;
        public string staffRole;
        public int staffAge;

        public Staff(string aStaffName, string aStaffRole, int aStaffAge)
        {
            staffName = aStaffName;
            staffRole = aStaffRole;
            staffAge = aStaffAge;
        }

        // figure out if staff members age is 25 and over

        public bool Is25AndOver()
        {
            if(staffAge >= 25)
            {
                return true;
            }
            return false;
        }
    }
}
