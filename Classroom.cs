using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_ValidateStudentInfo
{

    public class Classroom
    {

       private Student[] expNetStudents = new Student[24];

        
        public Classroom()
        {
            for (int i = 1; i < expNetStudents.Length; i++)
            {
                expNetStudents[i] = new Student();
            }
            expNetStudents[1].FirstName = "Mo";
            expNetStudents[1].LastName = "Yang";
            expNetStudents[1].Hometown = "Beijing";
            expNetStudents[1].FavoriteFood = "Pho";
                  
            expNetStudents[2].FirstName = "Alex";
            expNetStudents[2].LastName = "Letinski";
            expNetStudents[2].Hometown = "Detroit";
            expNetStudents[2].FavoriteFood = "Pizza";
                  
            expNetStudents[3].FirstName = "Alexander";
            expNetStudents[3].LastName = "Rashid";
            expNetStudents[3].Hometown = "Detroit";
            expNetStudents[3].FavoriteFood = "Pizza";
                  
            expNetStudents[4].FirstName = "Athikumar";
            expNetStudents[4].LastName = "Chinnathambi";
            expNetStudents[4].Hometown = "Detroit";
            expNetStudents[4].FavoriteFood = "Pizza";
                  
            expNetStudents[5].FirstName = "Chowdhury";
            expNetStudents[5].LastName = "Afrin";
            expNetStudents[5].Hometown = "Detroit";
            expNetStudents[5].FavoriteFood = "Pizza";
                  
            expNetStudents[6].FirstName = "Calvin";
            expNetStudents[6].LastName = "Ferguson";
            expNetStudents[6].Hometown = "Detroit";
            expNetStudents[6].FavoriteFood = "Pizza";
                  
            expNetStudents[7].FirstName = "Christian";
            expNetStudents[7].LastName = "Phillips";
            expNetStudents[7].Hometown = "Detroit";
            expNetStudents[7].FavoriteFood = "Pizza";

            expNetStudents[8].FirstName = "Darius";
            expNetStudents[8].LastName = "Hunter";
            expNetStudents[8].Hometown = "Detroit";
            expNetStudents[8].FavoriteFood = "Pizza";

            expNetStudents[9].FirstName = "Elbert";
            expNetStudents[9].LastName = "Powers";
            expNetStudents[9].Hometown = "Detroit";
            expNetStudents[9].FavoriteFood = "Pizza";

            expNetStudents[10].FirstName = "Gaby";
            expNetStudents[10].LastName = "Avila";
            expNetStudents[10].Hometown = "Detroit";
            expNetStudents[10].FavoriteFood = "Pizza";

            expNetStudents[11].FirstName = "Gayatri";
            expNetStudents[11].LastName = "Tanneeru";
            expNetStudents[11].Hometown = "India";
            expNetStudents[11].FavoriteFood = "Dosa";

            expNetStudents[12].FirstName = "Hemory";
            expNetStudents[12].LastName = "Phifer";
            expNetStudents[12].Hometown = "Detroit";
            expNetStudents[12].FavoriteFood = "Pizza";

            expNetStudents[13].FirstName = "Lauren";
            expNetStudents[13].LastName = "Bradford";
            expNetStudents[13].Hometown = "Detroit";
            expNetStudents[13].FavoriteFood = "Pizza";

            expNetStudents[14].FirstName = "Michael";
            expNetStudents[14].LastName = "Buckley";
            expNetStudents[14].Hometown = "Detroit";
            expNetStudents[14].FavoriteFood = "Pizza";           

            expNetStudents[15].FirstName = "Michelle";
            expNetStudents[15].LastName = "Myricks";
            expNetStudents[15].Hometown = "Detroit";
            expNetStudents[15].FavoriteFood = "Pizza";

            expNetStudents[16].FirstName = "Muhammad";
            expNetStudents[16].LastName = "Harris";
            expNetStudents[16].Hometown = "Detroit";
            expNetStudents[16].FavoriteFood = "Pizza";

            expNetStudents[17].FirstName = "Noah";
            expNetStudents[17].LastName = "Vrazo";
            expNetStudents[17].Hometown = "Detroit";
            expNetStudents[17].FavoriteFood = "Pizza";

            expNetStudents[18].FirstName = "Phil";
            expNetStudents[18].LastName = "Adamczyk";
            expNetStudents[18].Hometown = "Detroit";
            expNetStudents[18].FavoriteFood = "Pizza";

            expNetStudents[19].FirstName = "Reginald";
            expNetStudents[19].LastName = "Davis";
            expNetStudents[19].Hometown = "Detroit";
            expNetStudents[19].FavoriteFood = "Pizza";

            expNetStudents[20].FirstName = "Renee";
            expNetStudents[20].LastName = "Hudson";
            expNetStudents[20].Hometown = "Detroit";
            expNetStudents[20].FavoriteFood = "Pizza";

            expNetStudents[21].FirstName = "Riddhi";
            expNetStudents[21].LastName = "Solanki";
            expNetStudents[21].Hometown = "Detroit";
            expNetStudents[21].FavoriteFood = "Pizza";

            expNetStudents[22].FirstName = "Rumi";
            expNetStudents[22].LastName = "Chakravarty";
            expNetStudents[22].Hometown = "Detroit";
            expNetStudents[22].FavoriteFood = "Pizza";

            expNetStudents[23].FirstName = "Sylvia";
            expNetStudents[23].LastName = "Hubbard";
            expNetStudents[23].Hometown = "Detroit";
            expNetStudents[23].FavoriteFood = "Pizza";
        }
        
        public Student[] students
        { get { return expNetStudents; } }

        public Student GetStudentIndexOf(int index)
        {
            if (index < 0 || index > expNetStudents.Length)
            {
                throw new Exception("This student does not exist. Please try again. (enter a number 1-22)");
            }
            return expNetStudents[index];
        }
    }
}