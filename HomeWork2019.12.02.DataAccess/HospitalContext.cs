namespace HomeWork2019._12._02.DataAccess
{
    using HomeWork2019._12._02.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class HospitalContext : DbContext
    {
        // Контекст настроен для использования строки подключения "HospitalContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "HomeWork2019._12._02.DataAccess.HospitalContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "HospitalContext" 
        // в файле конфигурации приложения.
        public HospitalContext()
            : base("name=HospitalContext")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Disease> Diseases { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}