using System;


namespace SATS_TestTask
{
    
    public class Security
    {
        /// <summary>
        /// Типы
        /// </summary>
        public class Types
        {
            /// <summary>
            /// Типы объекта оргструктуры
            /// </summary>
            public enum OrganizationItemType
            {
                /// <summary>
                /// Должность
                /// </summary>
                Position,
                /// <summary>
                /// Отдел/Подразделение
                /// </summary>
                Department,
                /// <summary>
                /// Группа сотрудников
                /// </summary>
                OrganizationGroup
            }
        }
        
        public class Models{
            /// <summary>
            /// Пользователь
            /// </summary>
            public class User{
                /// <summary>
                /// Идентификатор записи БД
                /// </summary>
                public long id { get; set; }
                /// <summary>
                /// Уникальный Идентификатор
                /// </summary>
                public Guid uid { get; set; }
                /// <summary>
                /// Логин
                /// </summary>
                public string login { get; set; }
                /// <summary>
                /// ФИО
                /// </summary>
                public string fullName { get; set; }
                /// <summary>
                /// Дата блокировки
                /// </summary>
                public DateTime? blockDate { get; set; }
                /// <summary>
                /// Перечень должностей
                /// </summary>
                public string positionHash { get; set; }
            }

            public class OrganizationItem {
                    /// <summary>
                    /// Идентификатор записи БД
                    /// </summary>
                    public long Id { get; set; }
                    /// <summary>
                    /// Уникальный идентификатор
                    /// </summary>
                    public Guid Uid { get; set; }
                    /// <summary>
                    /// Объект родитель
                    /// </summary>
                    public long? Parent { get; set; }
                    /// <summary>
                    /// Наименование
                    /// </summary>
                    public string Name { get; set; }
                    /// <summary>
                    /// Тип объекта орг. структуры
                    /// </summary>
                    public Security.Types.OrganizationItemType orgItemType { get; set; }
            }
        }
    }
}