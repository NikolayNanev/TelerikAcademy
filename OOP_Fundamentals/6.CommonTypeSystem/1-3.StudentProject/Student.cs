namespace StudentProject
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string ssn;
        private string mobilePhone;
        private string eMail;

        public Student(string firstName, string middleName, string lastName, string SSN) 
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = SSN;
        }

        public Student(string firstName, string middleName, string lastName, 
            string SSN, string address, string mobilePhone, string eMail, string course, 
            Specialty specialty, Faculty faculty, University university)
            : this(firstName, middleName, lastName,  SSN)
        {
            
            this.Address = address;
            this.MobilePhone = mobilePhone;
            this.EMail = eMail;
            this.Course = course;
            this.University = university;
            this.Faculty = faculty;
            this.Specialty = specialty;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name can't be null or empty !");
                }

                this.firstName = value;
            }
        }
        public string MiddleName
        {
            get { return this.middleName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Middle name can't be null or empty !");
                }

                this.middleName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name can't be null or empty !");
                }

                this.lastName = value;
            }
        }

        public string SSN 
        {
            get { return this.ssn; }
            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The Social Security number can't be null or empty");
                }

                if (!Regex.IsMatch(value, @"([0-9]{10})"))
                {
                    throw new ApplicationException("The Social Security number must a 10 digits number");
                }

                this.ssn = value;
            }
        }
        public string Address { get; set; }
        public string MobilePhone
        {
            get { return this.mobilePhone; }
            set
            {
                if (!Regex.IsMatch(value, @"(\+359[0-9]{9})") && !Regex.IsMatch(value, @"(0[0-9]{9})"))  
                {
                    throw new ApplicationException("Mobile phone numbers begin with +359 / 0 followed by 9 digits");
                }

                this.mobilePhone = value;
            }
        }
        public string EMail
        {
            get { return eMail; }
            set 
            {
                if (!Regex.IsMatch(value,@"(\w+@\w+.\w+)"))
                {
                    throw new ApplicationException("Invalid e-mail format");
                }

                eMail = value; 
            }
        }
        public string Course { get; set; }

        public University University { get; set; } 
        public Faculty Faculty { get; set; }
        public Specialty Specialty { get; set; }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ SSN.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;

            if (student == null)
            {
                return false;
            }

            if (!Object.Equals(this.FirstName, student.FirstName)
                ||!Object.Equals(this.MiddleName, student.MiddleName)
                ||!Object.Equals(this.LastName, student.LastName)
                ||!Object.Equals(this.SSN, student.SSN) )
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append(String.Format("Name: {0} {1} {2}", this.FirstName, this.MiddleName, this.LastName));
            builder.Append(String.Format("\nUniversity: {0}", this.University));
            builder.Append(String.Format("\nFaculty: {0}", this.Faculty));
            builder.Append(String.Format("\nSpecialty: {0}", this.Specialty));

            return builder.ToString();
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return Student.Equals(firstStudent, secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !Student.Equals(firstStudent, secondStudent);
        }

        public Student Clone() //Not type object, but type Student
        {
            Student cloneStudent = new Student(this.FirstName, this.MiddleName, this.LastName,
                this.SSN, this.Address, this.MobilePhone, this.EMail, this.Course,
                this.Specialty, this.Faculty,  this.University);

            return cloneStudent;  // Not return cloneStudent as object;
        }

        //Not needed to cast object to (Student)
        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public int CompareTo(Student otherStudent) 
        {
            //Names as first criteria (in lexicographic order)
            if (firstName.CompareTo(otherStudent.FirstName) != 0)
            {
                return FirstName.CompareTo(otherStudent.FirstName);
            }

            else if (MiddleName.CompareTo(otherStudent.MiddleName) != 0)
            {
                return MiddleName.CompareTo(otherStudent.MiddleName);
            }

            else if (LastName.CompareTo(otherStudent.LastName) != 0)
            {
                return LastName.CompareTo(otherStudent.LastName); 
            }

            // SSN as second criteria (in increasing order)
            else
            {
                return SSN.CompareTo(otherStudent.SSN);
            }
        }
    }
}