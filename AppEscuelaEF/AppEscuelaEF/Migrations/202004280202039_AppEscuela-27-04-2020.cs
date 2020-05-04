namespace AppEscuelaEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AppEscuela27042020 : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.Cursos",
            //    c => new
            //        {
            //            CursoId = c.Int(nullable: false, identity: true),
            //            Nombre = c.String(nullable: false, maxLength: 50),
            //            Descripcion = c.String(nullable: false, maxLength: 50),
            //        })
            //    .PrimaryKey(t => t.CursoId);
            
            //CreateTable(
            //    "dbo.Estudiantes",
            //    c => new
            //        {
            //            EstudianteId = c.Int(nullable: false, identity: true),
            //            Nombres = c.String(nullable: false, maxLength: 50),
            //            Apellidos = c.String(nullable: false, maxLength: 50),
            //            FechaNacimiento = c.DateTime(nullable: false),
            //            GradoId = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.EstudianteId)
            //    .ForeignKey("dbo.Grados", t => t.GradoId, cascadeDelete: true)
            //    .Index(t => t.GradoId);
            
            //CreateTable(
            //    "dbo.EstudiantesDirecciones",
            //    c => new
            //        {
            //            EstudianteDireccionId = c.Int(nullable: false),
            //            Direccion1 = c.String(nullable: false, maxLength: 50),
            //            Direccion2 = c.String(),
            //            Provincia = c.String(nullable: false, maxLength: 50),
            //            Departamento = c.String(nullable: false, maxLength: 50),
            //        })
            //    .PrimaryKey(t => t.EstudianteDireccionId)
            //    .ForeignKey("dbo.Estudiantes", t => t.EstudianteDireccionId)
            //    .Index(t => t.EstudianteDireccionId);
            
            //CreateTable(
            //    "dbo.Grados",
            //    c => new
            //        {
            //            GradoId = c.Int(nullable: false, identity: true),
            //            GradoNombre = c.String(nullable: false, maxLength: 50),
            //            Seccion = c.String(nullable: false, maxLength: 50),
            //        })
            //    .PrimaryKey(t => t.GradoId);
            
            CreateTable(
                "dbo.EstudiantesCursos",
                c => new
                    {
                        EstudianteId = c.Int(nullable: false),
                        CursoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.EstudianteId, t.CursoId })
                .ForeignKey("dbo.Cursos", t => t.CursoId, cascadeDelete: true)
                .ForeignKey("dbo.Estudiantes", t => t.EstudianteId, cascadeDelete: true)
                .Index(t => t.EstudianteId)
                .Index(t => t.CursoId);
            
            //CreateTable(
            //    "dbo.EstudianteCurso1",
            //    c => new
            //        {
            //            Estudiante_EstudianteId = c.Int(nullable: false),
            //            Curso_CursoId = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.Estudiante_EstudianteId, t.Curso_CursoId })
            //    .ForeignKey("dbo.Estudiantes", t => t.Estudiante_EstudianteId, cascadeDelete: true)
            //    .ForeignKey("dbo.Cursos", t => t.Curso_CursoId, cascadeDelete: true)
            //    .Index(t => t.Estudiante_EstudianteId)
            //    .Index(t => t.Curso_CursoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EstudiantesCursos", "EstudianteId", "dbo.Estudiantes");
            DropForeignKey("dbo.EstudiantesCursos", "CursoId", "dbo.Cursos");
            DropForeignKey("dbo.Estudiantes", "GradoId", "dbo.Grados");
            DropForeignKey("dbo.EstudiantesDirecciones", "EstudianteDireccionId", "dbo.Estudiantes");
            DropForeignKey("dbo.EstudianteCurso1", "Curso_CursoId", "dbo.Cursos");
            DropForeignKey("dbo.EstudianteCurso1", "Estudiante_EstudianteId", "dbo.Estudiantes");
            DropIndex("dbo.EstudianteCurso1", new[] { "Curso_CursoId" });
            DropIndex("dbo.EstudianteCurso1", new[] { "Estudiante_EstudianteId" });
            DropIndex("dbo.EstudiantesCursos", new[] { "CursoId" });
            DropIndex("dbo.EstudiantesCursos", new[] { "EstudianteId" });
            DropIndex("dbo.EstudiantesDirecciones", new[] { "EstudianteDireccionId" });
            DropIndex("dbo.Estudiantes", new[] { "GradoId" });
            DropTable("dbo.EstudianteCurso1");
            DropTable("dbo.EstudiantesCursos");
            DropTable("dbo.Grados");
            DropTable("dbo.EstudiantesDirecciones");
            DropTable("dbo.Estudiantes");
            DropTable("dbo.Cursos");
        }
    }
}
