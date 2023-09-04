namespace Course08.Entities
{
    internal class Student
    {
        public int Enrollment { get; set; }

        public Student(int enrollment)
        {
            Enrollment = enrollment;
        }

        public override int GetHashCode()
        {
            return Enrollment.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Student))
            {
                return false;
            }

            Student other = obj as Student;
            return Enrollment.Equals(other.Enrollment);
        }
    }
}
