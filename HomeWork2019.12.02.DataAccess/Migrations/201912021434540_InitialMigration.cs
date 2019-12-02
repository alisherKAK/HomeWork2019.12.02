namespace HomeWork2019._12._02.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Diseases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Specialist = c.String(),
                        SpecialistFullName = c.String(),
                        Diagnosis = c.String(),
                        Complaints = c.String(),
                        VisitDate = c.DateTime(nullable: false),
                        Patient_Id = c.Int(),
                        Patient_Iin = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Patients", t => new { t.Patient_Id, t.Patient_Iin })
                .Index(t => new { t.Patient_Id, t.Patient_Iin });
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Iin = c.String(nullable: false, maxLength: 128),
                        FullName = c.String(),
                        Address = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => new { t.Id, t.Iin });
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Diseases", new[] { "Patient_Id", "Patient_Iin" }, "dbo.Patients");
            DropIndex("dbo.Diseases", new[] { "Patient_Id", "Patient_Iin" });
            DropTable("dbo.Patients");
            DropTable("dbo.Diseases");
        }
    }
}
