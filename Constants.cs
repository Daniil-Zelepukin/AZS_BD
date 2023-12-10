using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace AZS_BD
    {
        /// <summary>
        /// Класс констант
        /// </summary>
        public static class Constants
        {
            /// <summary>
            /// Имена таблиц
            /// </summary>
            public static class TableNames
            {
                /// <summary>
                /// Рабочая информация работника
                /// </summary>
                public const string InfoWorkersTableName = "InfoWorkers";
                /// <summary>
                /// Вакансии
                /// </summary>
                public const string TitlesTableName = "Titles";
                /// <summary>
                /// ФИО работника
                /// </summary>
                public const string UnitTableName = "Unit";
                /// <summary>
                /// Личная информация работника
                /// </summary>
                public const string WorkersTableName = "Workers";

            }
            public static class FieldsName
            {
                public const string Id = "Id";
                public static class TitlesTable
                {
                    public const string Titles = "Titles";
                }
                public static class UnitTable
                {
                    public const string UnitId = "UnittId";
                    public const string LastName = "LastName";
                    public const string FirstName = "FirstName";
                    public const string MiddleName = "MidleName";

                }
                public static class WorkersTable
                {
                    public const string WorkerId = "WorkerId";
                    public const string Age = "Age";
                    public const string DataOfBirth = "DataOfBirth";
                    public const string Nationality = "Nationality";
                    public const string MailWorker = "MailWorker";
                    public const string NumberPhoneWorker = "NumberPhoneWorker";
                    public const string Address = "Address";
                    public const string PhotoFileName = "PhotoFileName";

                }
                public static class InfoWorkersTable
                {
                    public const string WorkerId = "WorkerId";
                    public const string Post = "Post";
                    public const string Education = "Education";
                    public const string Experience = "Experience";
                    public const string WorkCard = "WorkCard";

                }
            }
            public static class ExcelCells
            {
                public static int A = 0;
                public static int B = 1;
                public static int C = 2;
                public static int D = 3;
                public static int E = 4;
                public static int F = 5;
                public static int G = 6;
                public static int H = 7;
                public static int I = 8;
                public static int J = 9;

            }
        }

    }
