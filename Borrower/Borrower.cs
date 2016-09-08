using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BorrowerLibrary
{
    public enum BorrowerType
    {
        Student,
        Faculty,
        NonTeachingPersonel
    }

    public class Borrower
    {
        public int Id { get; set; }
        public int StudentEmployeeId { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public int Gender { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public BorrowerType UserType { get; set; }

        private List<Borrower> BorrowerList;
        public void InitializeBorrower()
        {
            BorrowerList = new List<Borrower>();

            BorrowerList.Add(new Borrower
            {
                Id = 1,
                Email = "idc@gmail.com",
                FirstName = "Ian",
                MiddleInitial = "T",
                LastName = "Dela Cruz",
                Gender = 1,
                Password = "idc",
                StudentEmployeeId = 2002110146,
                UserType = BorrowerType.Student
            });

            BorrowerList.Add(new Borrower
            {
                Id = 2,
                Email = "vmm@gmail.com",
                FirstName = "Vida Marie",
                MiddleInitial = "M",
                LastName = "Marilag",
                Gender = 1,
                Password = "vmm",
                StudentEmployeeId = 1234567,
                UserType = BorrowerType.Faculty
            });

            BorrowerList.Add(new Borrower
            {
                Id = 3,
                Email = "coo@gmail.com",
                FirstName = "Marco",
                MiddleInitial = "Y",
                LastName = "Santos",
                Gender = 1,
                Password = "coo",
                StudentEmployeeId = 1234567,
                UserType = BorrowerType.NonTeachingPersonel
            });

            SaveBorrowers();
        }
        public bool CheckEmailAvailability(string email)
        {
            if (BorrowerList == null)
                LoadBorrowers();

            if (BorrowerList.FirstOrDefault(h => h.Email == email) != null)
                return false;
            else
                return true;

        }
        public int Register()
        {
            if (BorrowerList == null)
                LoadBorrowers();

            var newId = BorrowerList.OrderByDescending(h=> h.Id).FirstOrDefault().Id + 1;

            BorrowerList.Add(new Borrower
            {
                Id = newId,
                Email = this.Email,
                FirstName = this.FirstName,
                MiddleInitial = this.MiddleInitial,
                LastName = this.LastName,
                Gender = this.Gender,
                Password = this.Password,
                StudentEmployeeId = this.StudentEmployeeId,
                UserType = this.UserType
            });

            SaveBorrowers();

            return newId;
        }
        public Borrower Login(string email, string Password)
        {
            LoadBorrowers();
            return BorrowerList.FirstOrDefault(h=> h.Email == email && h.Password == Password);
        }

        private void LoadBorrowers()
        {
            BorrowerList = new List<Borrower>();
            var json = File.ReadAllText(Environment.CurrentDirectory + "\\user.txt");
            BorrowerList = JsonConvert.DeserializeObject<List<Borrower>>(json);
        }
        private void SaveBorrowers()
        {
            string json = JsonConvert.SerializeObject(BorrowerList);
            File.WriteAllText(Environment.CurrentDirectory + "\\user.txt", json);
        }
        
    }
}

