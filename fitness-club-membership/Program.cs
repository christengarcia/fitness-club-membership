using System;

namespace fitness_club_membership
{
    class Member
    {
        //protected int annualFee;
        private string name;
        private int memberID;
        private int memberSince;

        public override string ToString()
        {
            return "\nName: " + name + "\nMember ID: " + memberID
                + "\nMember Since: " + memberSince + "\nTotal Annual Fee: "
                + annualFee;
        }

        public Member()
        {
            Console.WriteLine("Parent Constructor with no parameter");
        }

        public Member(string pName, int pMemberID, int pMemberSince)
        {
            Console.WriteLine("Parent Constructor with 3 parameters");

            name = pName;
            memberID = pMemberID;
            memberSince = pMemberSince;
        }
    }

    class NormalMember : Member
    {
        public NormalMember(string remarks, string name, int memberID, int memberSince) 
            : base (name, memberID, memberSince)
        {
            Console.WriteLine("Child Constructor with 4 parameters");
            Console.WriteLine("Remarks = {0}", remarks);
        }
    }
}