using System;
using System.Collections.Generic;

namespace SATS_TestTask
{
    /// <summary>
    /// Данные
    /// </summary>
    public static class Data
    {
        /// <summary>
        /// Пользователи системы
        /// </summary>
        public static readonly List<Security.Models.User> Users =
            new List<Security.Models.User>
            {
                new Security.Models.User
                {
                    id = 1,
                    uid = Guid.NewGuid(),
                    login = "ii_ivanov",
                    fullName = "Иванов Иван Иванович",
                    blockDate = null,
                    positionHash = "1"
                },
                new Security.Models.User
                {
                    id = 2,
                    uid = Guid.NewGuid(),
                    login = "pp_petrov",
                    fullName = "Петров Пётр Петрович",
                    blockDate = null,
                    positionHash = "2"
                },
                new Security.Models.User
                {
                    id = 3,
                    uid = Guid.NewGuid(),
                    login = "s_sidorov",
                    fullName = "Сидоров Сергей Сергеевич",
                    blockDate = null,
                    positionHash = "3"
                },
                new Security.Models.User
                {
                    id = 4,
                    uid = Guid.NewGuid(),
                    login = "aa_andreev",
                    fullName = "Андреев Андрей Андреевич",
                    blockDate = null,
                    positionHash = "4"
                },
                new Security.Models.User
                {
                    id = 5,
                    uid = Guid.NewGuid(),
                    login = "kk_kuznetsov",
                    fullName = "Кузнецов Константин Константинович",
                    blockDate = DateTime.UtcNow.AddMonths(-4),
                    positionHash = "6"
                },
                new Security.Models.User
                {
                    id = 6,
                    uid = Guid.NewGuid(),
                    login = "dd_smirnov",
                    fullName = "Смирнов Дмитрий Дмитриевич",
                    blockDate = null,
                    positionHash = "6,14"
                },
                new Security.Models.User
                {
                    id = 7,
                    uid = Guid.NewGuid(),
                    login = "pp_popov",
                    fullName = "Попов Павел Павлович",
                    blockDate = null,
                    positionHash = "11"
                },
                new Security.Models.User
                {
                    id = 8,
                    uid = Guid.NewGuid(),
                    login = "vv_vasiliev",
                    fullName = "Васильев Василий Васильевич",
                    blockDate = DateTime.UtcNow.AddDays(-10),
                    positionHash = "14"
                },
                new Security.Models.User
                {
                    id = 9,
                    uid = Guid.NewGuid(),
                    login = "nn_novikov",
                    fullName = "Новиков Николай Николаевич",
                    blockDate = null,
                    positionHash = "17"
                },
                new Security.Models.User
                {
                    id = 10,
                    uid = Guid.NewGuid(),
                    login = "ff_fedorov",
                    fullName = "Фёдоров Фёдор Фёдорович",
                    blockDate = null,
                    positionHash = "19"
                },
                new Security.Models.User
                {
                    id = 11,
                    uid = Guid.NewGuid(),
                    login = "mm_morozov",
                    fullName = "Морозов Михаил Михайлович",
                    blockDate = null,
                    positionHash = "21,24"
                },
                new Security.Models.User
                {
                    id = 12,
                    uid = Guid.NewGuid(),
                    login = "vv_volkov",
                    fullName = "Волков Владимир Владимирович",
                    blockDate = null,
                    positionHash = "12"
                },
                new Security.Models.User
                {
                    id = 13,
                    uid = Guid.NewGuid(),
                    login = "aa_alexeev",
                    fullName = "Алексеев Алексей Алексеевич",
                    blockDate = null,
                    positionHash = "8"
                },
                new Security.Models.User
                {
                    id = 14,
                    uid = Guid.NewGuid(),
                    login = "ll_lebedev",
                    fullName = "Лебедев Леонид Леонидович",
                    blockDate = null,
                    positionHash = "15"
                },
                new Security.Models.User
                {
                    id = 15,
                    uid = Guid.NewGuid(),
                    login = "sssemenov",
                    fullName = "Семёнов Семён Семёнович",
                    blockDate = null,
                    positionHash = "12"
                },
                new Security.Models.User
                {
                    id = 16,
                    uid = Guid.NewGuid(),
                    login = "ee_egorov",
                    fullName = "Егоров Евгений Евгеньевич",
                    blockDate = null,
                    positionHash = "12"
                },
                new Security.Models.User
                {
                    id = 17,
                    uid = Guid.NewGuid(),
                    login = "sysadmin1",
                    fullName = "Никитин Никита Никитич",
                    blockDate = null,
                    positionHash = "9"
                },
                new Security.Models.User
                {
                    id = 18,
                    uid = Guid.NewGuid(),
                    login = "sysadmin2",
                    fullName = "Орлов Олег Олегович",
                    blockDate = null,
                    positionHash = "9"
                },
                new Security.Models.User
                {
                    id = 19,
                    uid = Guid.NewGuid(),
                    login = "mm_makarov",
                    fullName = "Макаров Максим Максимович",
                    blockDate = null,
                    positionHash = "15"
                },
                new Security.Models.User
                {
                    id = 20,
                    uid = Guid.NewGuid(),
                    login = "zz_zaharov",
                    fullName = "Захаров Захар Захарович",
                    blockDate = null,
                    positionHash = "15"
                },
                new Security.Models.User
                {
                    id = 21,
                    uid = Guid.NewGuid(),
                    login = "ssstepanov",
                    fullName = "Степанов Степан Степанович",
                    blockDate = null,
                    positionHash = "22"
                },
                new Security.Models.User
                {
                    id = 22,
                    uid = Guid.NewGuid(),
                    login = "pp_pavlov",
                    fullName = "Павлов Пётр Павлович",
                    blockDate = null,
                    positionHash = "25"
                },
                new Security.Models.User
                {
                    id = 23,
                    uid = Guid.NewGuid(),
                    login = "rr_romanov",
                    fullName = "Романов Роман Романович",
                    blockDate = DateTime.UtcNow.AddYears(-1),
                    positionHash = "9,22"
                }
            };

        /// <summary>
        /// Элементы оргструктуры
        /// </summary>
        public static readonly List<Security.Models.OrganizationItem> OrganizationItems =
            new List<Security.Models.OrganizationItem>
            {
                new Security.Models.OrganizationItem
                {
                    Id = 1,
                    Uid = Guid.NewGuid(),
                    Parent = null,
                    Name = "Генеральный директор",
                    orgItemType = Security.Types.OrganizationItemType.Position
                },
                new Security.Models.OrganizationItem
                {
                    Id = 2,
                    Uid = Guid.NewGuid(),
                    Parent = 1,
                    Name = "Заместитель директора по ИТ",
                    orgItemType = Security.Types.OrganizationItemType.Position
                },
                new Security.Models.OrganizationItem
                {
                    Id = 3,
                    Uid = Guid.NewGuid(),
                    Parent = 1,
                    Name = "Заместитель директора по операционной деятельности",
                    orgItemType = Security.Types.OrganizationItemType.Position
                },
                new Security.Models.OrganizationItem
                {
                    Id = 4,
                    Uid = Guid.NewGuid(),
                    Parent = 1,
                    Name = "Заместитель директора по финансам",
                    orgItemType = Security.Types.OrganizationItemType.Position
                },
                new Security.Models.OrganizationItem
                {
                    Id = 5,
                    Uid = Guid.NewGuid(),
                    Parent = 2,
                    Name = "Отдел информационных систем",
                    orgItemType = Security.Types.OrganizationItemType.Department
                },
                new Security.Models.OrganizationItem
                {
                    Id = 6,
                    Uid = Guid.NewGuid(),
                    Parent = 5,
                    Name = "Начальник отдела информационных систем",
                    orgItemType = Security.Types.OrganizationItemType.Position
                },
                new Security.Models.OrganizationItem
                {
                    Id = 7,
                    Uid = Guid.NewGuid(),
                    Parent = 5,
                    Name = "Группа системных администраторов",
                    orgItemType = Security.Types.OrganizationItemType.OrganizationGroup
                },
                new Security.Models.OrganizationItem
                {
                    Id = 8,
                    Uid = Guid.NewGuid(),
                    Parent = 7,
                    Name = "Ведущий системный администратор",
                    orgItemType = Security.Types.OrganizationItemType.Position
                },
                new Security.Models.OrganizationItem
                {
                    Id = 9,
                    Uid = Guid.NewGuid(),
                    Parent = 7,
                    Name = "Системный администратор",
                    orgItemType = Security.Types.OrganizationItemType.Position
                },
                new Security.Models.OrganizationItem
                {
                    Id = 10,
                    Uid = Guid.NewGuid(),
                    Parent = 2,
                    Name = "Отдел разработки",
                    orgItemType = Security.Types.OrganizationItemType.Department
                },
                new Security.Models.OrganizationItem
                {
                    Id = 11,
                    Uid = Guid.NewGuid(),
                    Parent = 10,
                    Name = "Начальник отдела разработки",
                    orgItemType = Security.Types.OrganizationItemType.Position
                },
                new Security.Models.OrganizationItem
                {
                    Id = 12,
                    Uid = Guid.NewGuid(),
                    Parent = 10,
                    Name = "Разработчик",
                    orgItemType = Security.Types.OrganizationItemType.Position
                },
                new Security.Models.OrganizationItem
                {
                    Id = 13,
                    Uid = Guid.NewGuid(),
                    Parent = 2,
                    Name = "Отдел сопровождения приложений",
                    orgItemType = Security.Types.OrganizationItemType.Department
                },
                new Security.Models.OrganizationItem
                {
                    Id = 14,
                    Uid = Guid.NewGuid(),
                    Parent = 13,
                    Name = "Начальник отдела сопровождения приложений",
                    orgItemType = Security.Types.OrganizationItemType.Position
                },
                new Security.Models.OrganizationItem
                {
                    Id = 15,
                    Uid = Guid.NewGuid(),
                    Parent = 13,
                    Name = "Аналитик",
                    orgItemType = Security.Types.OrganizationItemType.Position
                },
                new Security.Models.OrganizationItem
                {
                    Id = 16,
                    Uid = Guid.NewGuid(),
                    Parent = 3,
                    Name = "Отдел тех. контроля",
                    orgItemType = Security.Types.OrganizationItemType.Department
                },
                new Security.Models.OrganizationItem
                {
                    Id = 17,
                    Uid = Guid.NewGuid(),
                    Parent = 16,
                    Name = "Начальник отдела тех. контроля",
                    orgItemType = Security.Types.OrganizationItemType.Position
                },
                new Security.Models.OrganizationItem
                {
                    Id = 18,
                    Uid = Guid.NewGuid(),
                    Parent = 3,
                    Name = "Отдел логистики",
                    orgItemType = Security.Types.OrganizationItemType.Department
                },
                new Security.Models.OrganizationItem
                {
                    Id = 19,
                    Uid = Guid.NewGuid(),
                    Parent = 18,
                    Name = "Начальник отдела логистики",
                    orgItemType = Security.Types.OrganizationItemType.Position
                },
                new Security.Models.OrganizationItem
                {
                    Id = 20,
                    Uid = Guid.NewGuid(),
                    Parent = 4,
                    Name = "Финансовый отдел",
                    orgItemType = Security.Types.OrganizationItemType.Department
                },
                new Security.Models.OrganizationItem
                {
                    Id = 21,
                    Uid = Guid.NewGuid(),
                    Parent = 20,
                    Name = "Начальник финансового отдела",
                    orgItemType = Security.Types.OrganizationItemType.Position
                },
                new Security.Models.OrganizationItem
                {
                    Id = 22,
                    Uid = Guid.NewGuid(),
                    Parent = 20,
                    Name = "Бухгалтер",
                    orgItemType = Security.Types.OrganizationItemType.Position
                },
                new Security.Models.OrganizationItem
                {
                    Id = 23,
                    Uid = Guid.NewGuid(),
                    Parent = 4,
                    Name = "Служба режима",
                    orgItemType = Security.Types.OrganizationItemType.Department
                },
                new Security.Models.OrganizationItem
                {
                    Id = 24,
                    Uid = Guid.NewGuid(),
                    Parent = 23,
                    Name = "Начальник службы режима",
                    orgItemType = Security.Types.OrganizationItemType.Position
                },
                new Security.Models.OrganizationItem
                {
                    Id = 25,
                    Uid = Guid.NewGuid(),
                    Parent = 23,
                    Name = "Главный специалист службы режима",
                    orgItemType = Security.Types.OrganizationItemType.Position
                }
            };
    }
}
