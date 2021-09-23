using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    using BusinessObjectLayer;

    public class LaboratoryReportDAL
    {
        private static string select = "SELECT LABORATORYSERVICE.DATE, LABORATORY.LABORATORYID, LABORATORY.LABORATORYTITLE, LABORATORYSTATE.LABORATORYSTATEID,  LABORATORYSTATE.LABORATORYSTATETITLE, SERVICETYPE.SERVICETYPEID, SERVICETYPE.SERVICETYPETITLE, PATIENT.FIRSTNAME,  PATIENT.LASTNAME, PATIENT.PATIENTCODE, dbo.GETPATIENTDISEASES(PATIENT.PATIENTID) AS DISEASES FROM LABORATORYSERVICE INNER JOIN LABORATORY ON LABORATORYSERVICE.LABORATORYID = LABORATORY.LABORATORYID INNER JOIN LABORATORYSTATE ON LABORATORYSERVICE.LABORATORYSTATEID = LABORATORYSTATE.LABORATORYSTATEID INNER JOIN SERVICE ON LABORATORYSERVICE.SERVICEID = SERVICE.SERVICEID INNER JOIN PATIENT ON SERVICE.PATIENTID = PATIENT.PATIENTID INNER JOIN SERVICETYPE ON SERVICE.SERVICETYPEID = SERVICETYPE.SERVICETYPEID WHERE (LABORATORYSERVICE.DATE >= @FROMDATE) AND (LABORATORYSERVICE.DATE <= @TODATE) AND  (LABORATORYSTATE.LABORATORYSTATEID = @LABORATORYSTATEID) AND (LABORATORY.LABORATORYID = @LABORATORYID) OR (LABORATORYSERVICE.DATE >= @FROMDATE) AND (LABORATORYSERVICE.DATE <= @TODATE) AND (@LABORATORYSTATEID IS NULL) AND  (LABORATORY.LABORATORYID = @LABORATORYID) OR (LABORATORYSERVICE.DATE >= @FROMDATE) AND (LABORATORYSERVICE.DATE <= @TODATE) AND  (LABORATORYSTATE.LABORATORYSTATEID = @LABORATORYSTATEID) AND (@LABORATORYID IS NULL) OR (LABORATORYSERVICE.DATE >= @FROMDATE) AND (LABORATORYSERVICE.DATE <= @TODATE) AND (@LABORATORYSTATEID IS NULL) AND  (@LABORATORYID IS NULL)";
        private static SqlCommand sqlCommand;

        public static List<LaboratoryReportItemsBOL> Select(LaboratoryReportFilterBOL _LaboratoryReportFilterBOL)
        {
            DataTable table = ExecuteReader(_LaboratoryReportFilterBOL);
            List<LaboratoryReportItemsBOL> result = new List<LaboratoryReportItemsBOL>();
            foreach (DataRow row in table.Rows)
            {
                DateTime Date = Convert.ToDateTime(row["DATE"]);
                string PersinaDate = DataConvertor.DataConvertor.ConvertToPersianDate(Date);
                short LaboratoryId = Convert.ToInt16(row["LABORATORYID"]);
                string LaboratoryTitle = Convert.ToString(row["LABORATORYTITLE"]);
                short LaboratoryStateId = Convert.ToInt16(row["LABORATORYSTATEID"]);
                string LaboratoryStateTitle = Convert.ToString(row["LABORATORYSTATETITLE"]);
                short ServiceTypeId = Convert.ToInt16(row["SERVICETYPEID"]);
                string ServiceTypeTitle = Convert.ToString(row["SERVICETYPETITLE"]);
                string FirstName = Convert.ToString(row["FIRSTNAME"]);
                string LastName = Convert.ToString(row["LASTNAME"]);
                string PatientCode = Convert.ToString(row["PATIENTCODE"]);
                string Diseases = Convert.ToString(row["DISEASES"]);
                result.Add(new LaboratoryReportItemsBOL(Date, PersinaDate, LaboratoryId, LaboratoryTitle, LaboratoryStateId, LaboratoryStateTitle, ServiceTypeId, ServiceTypeTitle, FirstName, LastName, PatientCode, Diseases));
            }
            return result;
        }
        private static DataTable ExecuteReader(LaboratoryReportFilterBOL _LaboratoryReportFilterBOL)
        {
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = select;
            sqlCommand.Parameters.Add("@LaboratoryId", SqlDbType.TinyInt).Value = ValidateParameter("@LaboratoryId", _LaboratoryReportFilterBOL.LaboratoryId, true);
            sqlCommand.Parameters.Add("@LaboratoryStateId", SqlDbType.TinyInt).Value = ValidateParameter("@LaboratoryStateId", _LaboratoryReportFilterBOL.LaboratoryStateId, true);
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime).Value = ValidateParameter("@FromDate", _LaboratoryReportFilterBOL.FromDate, false);
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = ValidateParameter("@ToDate", _LaboratoryReportFilterBOL.ToDate, false);
            ConnectionDAL _ConnectionDAL = new ConnectionDAL();
            sqlCommand.Connection = _ConnectionDAL.OpenConnection();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlCommand.ExecuteReader());
            _ConnectionDAL.CloseConnection();
            return dataTable;
        }
        private static object ValidateParameter(string ParameterName, object Value, bool IsNullable)
        {
            if (Value == null && !IsNullable)
                throw new ArgumentNullException(ParameterName);
            return (Value == null ? DBNull.Value : Value);
        }
    }
}