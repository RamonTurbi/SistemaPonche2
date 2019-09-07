
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaPoncheOficial.Controllers;
using SistemaPoncheOficial.Models;
using Dapper;

namespace SistemaPoncheOficial.Controllers
{
    class ModalidadContratoController
    {

        ConexionDB conexionDB = new ConexionDB();

        public List<ModalidadContratoModel> SelectModalidadContratos()
        {
            Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;
            return conexionDB.Conectar().Query<ModalidadContratoModel>("Select * from modalidades_contrato where eliminado='no'").ToList();
        }
        public List<ModalidadContratoModel> SelectModalidadContratoByID(string idModalidad)
        {
            return conexionDB.Conectar().Query<ModalidadContratoModel>("Select * from modalidades_contrato where id_modalidad=" + idModalidad).ToList();
        }

        public List<ModalidadContratoModel> SelectNombreModalidad(string nombreModalidad)
        {
            return conexionDB.Conectar().Query<ModalidadContratoModel>("Select id_modalidad from modalidades_contrato where nombre_modaliad='" + nombreModalidad+"'").ToList();
        }

        public int InsetarModalidadContrato(ModalidadContratoModel modalidadContrato)
        {
            return conexionDB.Conectar().Execute("Insert into modalidades_contrato(nombre_modaliad)VALUES(@NombreModaliad)", modalidadContrato);
        }
        public int DeleteModalidadContrato(ModalidadContratoModel modalidadContrato)
        {
            return conexionDB.Conectar().Execute("Update modalidades_contrato set eliminado='si' where id_modalidad=@IdModalidad", modalidadContrato);
        }
        public int UpdateModalidadContrato(ModalidadContratoModel modalidadContrato)
        {
            return conexionDB.Conectar().Execute("Update modalidades_contrato set nombre_modaliad=@NombreModaliad where id_modalidad=@IdModalidad", modalidadContrato);
        }

    }
}
