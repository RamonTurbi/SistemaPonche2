
using Dapper;
using SistemaPoncheOficial.Models;
using System.Collections.Generic;
using System.Linq;

namespace SistemaPoncheOficial.Controllers
{
    class PersonasController
    {
        ConexionDB conexionDB = new ConexionDB();

        public List<PersonasModel> SelectPersonas()
        {
            return conexionDB.Conectar().Query<PersonasModel>("Select * from personas where eliminado='no'").ToList();
        }
        public List<PersonasModel> SelectPersonaByID(string idPersona)
        {
            return conexionDB.Conectar().Query<PersonasModel>("Select * from personas where Id_Persona=" + idPersona).ToList();
        }
        public List<PersonasModel> RetornoMaxID()
        {
            return conexionDB.Conectar().Query<PersonasModel>("SELECT MAX(id_persona) as id_persona FROM personas").ToList();
        }
        public int InsetarPersona(PersonasModel personasModel)
        {
            return conexionDB.Conectar().Execute("Insert into personas(primer_nombre,segundo_nombre,primer_apellido," +
            "segundo_apellido,documento,tipo_documento,telefono_1,tipo_telefono_1,telefono_2,tipo_telefono_2,telefono_3,tipo_telefono_3," +
            "calle_direccion,numero_direccion,sector_direccion,ciudad_direccion,pais_direccion,referencia_direccion,correo," +
            "nacionalidad,sexo)VALUES(@PrimerNombre,@SegundoNombre,@PrimerApellido,@SegundoApellido,@Documento,@TipoDocumento,@Telefono1," +
            "@TipoTelefono1,@Telefono2,@TipoTelefono2,@Telefono3,@TipoTelefono3,@CalleDireccion,@NumeroDireccion,@SectorDireccion," +
            "@CiudadDireccion,@PaisDireccion,@ReferenciaDireccion,@Correo,@Nacionalidad,@Sexo)", personasModel);
        }
        public int DeletePersona(PersonasModel personasModel)
        {
            return conexionDB.Conectar().Execute("Update personas set eliminado='si' where id_Persona=@IdPersona", personasModel);
        }
        public int UpdatePersona(PersonasModel personasModel)
        {
            return conexionDB.Conectar().Execute("Update personas set primer_nombre=@PrimerNombre,segundo_nombre=@SegundoNombre,primer_apellido = @PrimerApellido, segundo_apellido = @SegundoApellido," +
            "documento = @Documento, tipo_documento = @TipoDocumento, telefono_1 = @Telefono1,tipo_telefono_1 = @TipoTelefono1, telefono_2 = @Telefono2, tipo_telefono_2 = @TipoTelefono2," +
            "telefono_3 = @Telefono3, tipo_telefono_3 = @TipoTelefono3,calle_direccion = @CalleDireccion, numero_direccion = @NumeroDireccion, sector_direccion = @SectorDireccion, " +
            "ciudad_direccion = @CiudadDireccion,pais_direccion = @PaisDireccion, referencia_direccion = @ReferenciaDireccion, correo = @Correo, nacionalidad = @Nacionalidad," +
            " sexo = @Sexo where id_Persona=@IdPersona", personasModel);


        }
    }
}
