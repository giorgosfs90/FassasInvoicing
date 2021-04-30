using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dapper;


//@AFM int,
//@EPONIMIA varchar(255),
//@DRASTIRIOTITA varchar(255),
//@DOY varchar(255),
//@DIEFTHINSI varchar(255),
//@POLI varchar(255),
//@TK int,
//@XORA varchar(255),
//@TILEONO int,
//@EMAIL varchar(255)1111111111111111111111 v1.00

namespace FassasInvoicingLibrary
{
    public class SqlConnector : IDataConnector
    {
        public Eteria CreatePelatis(Eteria model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("INVOICING")))
            {
                var p = new DynamicParameters();
                p.Add("@AFM", model.Afm);
                p.Add("@EPONIMIA", model.Eponimia);
                p.Add("@DRASTIRIOTITA", model.Drastiriotita);
                p.Add("@DOY", model.Doy);
                p.Add("@DIEFTHINSI", model.Diefthinsi);
                p.Add("@POLI", model.Poli);
                p.Add("@TK", model.Tk);
                p.Add("@XORA", model.Xora);
                p.Add("@TILEFONO", model.Tilefono);
                p.Add("@EMAIL", model.Email);

                connection.Execute("dbo.spETERIES_INSERT", p, commandType: CommandType.StoredProcedure);
                return model;
            }
        }

        public Invoice CreateInvoice(Invoice model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("INVOICING")))
            {
                var p = new DynamicParameters();
                p.Add("@AA", model.AuksonArithmos);
                p.Add("@HMEROMINIA", model.Imerominia);
                p.Add("@POSOTITA", model.Afm);
                p.Add("@DOY", model.Perigrafi);
                p.Add("@DIEFTHINSI", model.Aksia);
                p.Add("@SYNOL_FPA", model.Sinolo_fpa);
                p.Add("@PLIROTEO", model.Pliroteo);
                p.Add("@TROPOS_PLIROMIS", model.Tropos_pliromis);


                connection.Execute("dbo.spETERIES_INSERT", p, commandType: CommandType.StoredProcedure);
                return model;
            }
        }

        public List<Eteria> GetEteries()
        {
            List<Eteria> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("INVOICING")))
            {
                output = connection.Query<Eteria>("dbo.spGetAllEteries").ToList();
            }
            return output;
        }
    }
}
