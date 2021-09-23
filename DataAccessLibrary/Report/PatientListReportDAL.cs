using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    using BusinessObjectLayer;
    using DataConvertor;

    public class PatientListReportDAL
    {
        private static string select = @"SELECT PATIENT.LASTNAME, PATIENT.FIRSTNAME, PATIENT.INSURANCECODE, SERVICE.DATE, SERVICE.PRICE, SERVICE.SERVICETYPEID, SERVICETYPE.SERVICETYPETITLE FROM SERVICE INNER JOIN PATIENT ON SERVICE.PATIENTID = PATIENT.PATIENTID INNER JOIN SERVICETYPE ON SERVICE.SERVICETYPEID = SERVICETYPE.SERVICETYPEID WHERE (PATIENT.INSURANCETYPEID = @INSURANCETYPEID) AND (SERVICE.DATE >= @FROMDATE) AND (SERVICE.DATE <= @TODATE) AND (SERVICE.ISFINISHED = 'TRUE') AND (@DOCTORID IN (SELECT MAX(DOCTORID) AS Expr1 FROM SERVICEHISTORY AS SERVICEHISTORY_2 WHERE     (SERVICEID = SERVICE.SERVICEID) AND (DATE = (SELECT MAX(DATE) AS MAXDATE FROM SERVICEHISTORY AS SERVICEHISTORY_1 WHERE (SERVICEID = SERVICE.SERVICEID)))))";
        private static string selectServiceCount = "SELECT dbo.GetServiceTypeCOUNT(SERVICETYPEID, @InsuranceTypeId, @DoctorId, @FromDate, @ToDate) AS COUNT, PRICE , SERVICETYPETITLE FROM SERVICETYPE";
        private static SqlCommand sqlCommand= new SqlCommand();

        public static List<PatientListReportItemsBOL> Select(PatientListReportFilterBOL _PatientListReportBOL)
        {
            sqlCommand.CommandText = select;
            DataTable table = ExecuteReader(_PatientListReportBOL);
            List<PatientListReportItemsBOL> result = new List<PatientListReportItemsBOL>();
            foreach (DataRow row in table.Rows)
            {
                string PatientName = string.Format("{0} {1}", row["FIRSTNAME"], row["LASTNAME"]);
                long InsuranceCode = Convert.ToInt64(row["INSURANCECODE"]);
                DateTime Date = Convert.ToDateTime(row["DATE"]);
                short ServiceTypeId = Convert.ToInt16(row["SERVICETYPEID"]);
                string ServiceTypeTitle = DataConvertor.ConvertToString(row["SERVICETYPETITLE"]);
                long Price = Convert.ToInt64(row["PRICE"]);
                result.Add(new PatientListReportItemsBOL(PatientName, InsuranceCode, Date, DataConvertor.ConvertToPersianDate(Date), ServiceTypeId, ServiceTypeTitle, Price));
            }
            return result;
        }
        public static List<PatientListReportPatientBOL> SelectServiceCount(PatientListReportFilterBOL _PatientListReportFilterBOL)
        {
            sqlCommand.CommandText = selectServiceCount;
            DataTable table = ExecuteReader(_PatientListReportFilterBOL);
            List<PatientListReportPatientBOL> result = new List<PatientListReportPatientBOL>();            
            foreach (DataRow row in table.Rows)
            {
                string ServiceTypeTitle = Convert.ToString(row["SERVICETYPETITLE"]);
                long Price = Convert.ToInt64(row["PRICE"]);
                int Count = Convert.ToInt32(row["COUNT"]);
                result.Add(new PatientListReportPatientBOL(ServiceTypeTitle, Price, Count));
            }
            return result;
        }
        private static DataTable ExecuteReader(PatientListReportFilterBOL _PatientListReportBOL)
        {
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.Add("@InsuranceTypeId", SqlDbType.TinyInt).Value = ValidateParameter("@InsuranceTypeId", _PatientListReportBOL.InsuranceTypeId, false);
            sqlCommand.Parameters.Add("@DoctorId", SqlDbType.TinyInt).Value = ValidateParameter("@DoctorId", _PatientListReportBOL.DoctorID, false);
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime).Value = ValidateParameter("@FromDate", _PatientListReportBOL.FromDate, false);
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = ValidateParameter("@ToDate", _PatientListReportBOL.ToDate, false);
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