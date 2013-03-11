using System;
using System.Collections.Generic;
using System.Text;

class Student : ICloneable, IComparable<Student>
{
    #region Fields
    private string firstName;
    private string middleName;
    private string lastName;
    private string ssn;
    private string address;
    private string mobile;
    private string email;
    private University university;
    private Faculty faculty;
    private Specialty specialty;
    private byte course;
    #endregion

    #region Cosntructors
    public Student(string firstName, string middleName, string lastName, string ssn, string address, string mobile, string email,
        byte course, University university, Faculty faculty, Specialty specialty)
    {
        this.FirstName = firstName;
        this.MiddleName = middleName;
        this.LastName = lastName;
        this.SSN = ssn;
        this.Address = address;
        this.Mobile = mobile;
        this.Email = email;
        this.Course = course;
        this.University = university;
        this.Faculty = faculty;
        this.Specialty = specialty;
        this.Course = course;
    }

    private Student()
    {
    }

    #endregion

    #region Properties
    public string FirstName
    {
        get { return firstName; }
        set
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("First name cannot be empty string!");
            }
            firstName = value;
        }
    }

    public string MiddleName
    {
        get { return middleName; }
        set
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Middle name cannot be empty string!");
            }
            middleName = value;
        }
    }

    public string LastName
    {
        get { return lastName; }
        set
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Last name cannot be empty string!");
            }
            lastName = value;
        }
    }

    public string SSN
    {
        get { return ssn; }
        set
        {
            if ((String.IsNullOrWhiteSpace(value)) || (value.Length != 9))
            {
                throw new ArgumentException("SSN cannot be empty or less/more then 9 digits!");
            }
            ssn = value;
        }
    }

    public string Address
    {
        get { return address; }
        set
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Address cannot be empty string!");
            }
            address = value;
        }
    }

    public string Mobile
    {
        get { return mobile; }
        set { mobile = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public University University
    {
        get { return university; }
        set { university = value; }
    }

    public Faculty Faculty
    {
        get { return faculty; }
        set { faculty = value; }
    }

    public Specialty Specialty
    {
        get { return specialty; }
        set { specialty = value; }
    }

    public byte Course
    {
        get { return course; }
        set
        {
            if (value > 5)
            {
                throw new ArgumentOutOfRangeException("Course should be [1,5]");
            }
            course = value;
        }
    }
    #endregion

    #region Methods

    // override  Equals()
    public override bool Equals(object param)
    {
        if (param == null)
        {
            return false;
        }

        Student student = param as Student;

        if (this.FirstName != student.FirstName)
        {
            return false;
        }

        if (this.MiddleName != student.MiddleName)
        {
            return false;
        }

        if (this.LastName != student.LastName)
        {
            return false;
        }

        if (this.SSN != student.SSN)
        {
            return false;
        }

        if (this.Address != student.Address)
        {
            return false;
        }

        if (this.Email != student.Email)
        {
            return false;
        }

        if (this.Mobile != student.Mobile)
        {
            return false;
        }

        if (this.University != student.University)
        {
            return false;
        }

        if (this.Faculty != student.Faculty)
        {
            return false;
        }

        if (this.Specialty != student.Specialty)
        {
            return false;
        }

        if (this.Course != student.Course)
        {
            return false;
        }
        return true;
    }

    // override ToString()
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("First name: " + this.FirstName);
        sb.AppendLine("Middle name: " + this.MiddleName);
        sb.AppendLine("Last name: " + this.LastName);
        sb.AppendLine("SSN: " + this.SSN);
        sb.AppendLine("Mobile: " + this.Mobile);
        sb.AppendLine("Email: " + this.Email);
        sb.AppendLine("Address: " + this.Address);
        sb.AppendLine("univeristy: " + this.University);
        sb.AppendLine("Faculty: " + this.Faculty);
        sb.AppendLine("Specialty: " + this.Specialty);
        sb.AppendLine("Course: " + this.Course);

        return sb.ToString();
    }

    // override GetHashCode()
    public override int GetHashCode()
    {
        return this.FirstName.GetHashCode() ^ this.MiddleName.GetHashCode() ^ this.LastName.GetHashCode() ^ this.SSN.GetHashCode() ^ this.University.GetHashCode();
    }

    // override ==
    public static bool operator ==(Student s1, Student s2)
    {
        return s1.Equals(s2);
    }

    // override !=
    public static bool operator !=(Student s1, Student s2)
    {
        return !s1.Equals(s2);
    }

    // implementation of Clone() method from Interface: IClonable
    object ICloneable.Clone()
    {
        return this.Clone();
    }

    public Student Clone()
    {
        Student s = new Student();

        s.FirstName = new String(this.FirstName.ToCharArray());
        s.MiddleName = new String(this.MiddleName.ToCharArray());
        s.LastName = new String(this.LastName.ToCharArray());
        s.SSN = new String(this.SSN.ToCharArray());
        s.Mobile = new String(this.Mobile.ToCharArray());
        s.Address = new String(this.Address.ToCharArray());
        s.email = new String(this.email.ToCharArray());
        s.University = this.University;
        s.Faculty = this.Faculty;
        s.Specialty = this.Specialty;
        s.Course = this.Course;

        return s;
    }
    // implementatio of CompareTo()
    
    #endregion


    public int CompareTo(Student other)
    {
        if (!this.LastName.Equals(other.LastName))
        {
            return String.Compare(this.LastName, other.LastName);
        }

        if (!this.FirstName.Equals(other.FirstName))
        {
            return String.Compare(this.FirstName, other.FirstName);
        }

        if (!this.SSN.Equals(other.SSN))
        {
            return String.Compare(this.SSN, other.SSN);
        }

        return 0;
    }
}
