using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    using BusinessObjectLayer;
    using DataConvertor;

    public class PrescriptionListReportDAL
    {
        private static string selectPrescriptionListReport = @"SELECT PATIENT.LASTNAME AS PATIENTLASTNAME, PATIENT.FIRSTNAME AS PATIENTFIRSTNAME, PATIENT.INSURANCECODE, SERVICE.DATE, dbo.GETDOCTORNAME(SERVICE.SERVICEID) AS DOCTORNAME, SERVICE.PRICE FROM SERVICE INNER JOIN PATIENT ON SERVICE.PATIENTID = PATIENT.PATIENTID WHERE (PATIENT.INSURANCETYPEID = @INSURANCETYPEID) AND (SERVICE.DATE >= @FROMDATE) AND (SERVICE.DATE <= @TODATE) AND (SERVICE.ISFINISHED = 'TRUE')";
        private static SqlCommand sqlCommand;

        public static List<PrescriptionListReportItemsBOL> Select(PrescriptionListReportFilterBOL _PrescriptionListReportBOL)
        {
            DataTable table = ExecuteReader(_PrescriptionListReportBOL);
            List<PrescriptionListReportItemsBOL> result = new List<PrescriptionListReportItemsBOL>();
            foreach (DataRow row in table.Rows)
            {
                string PatientName = string.Format("{0} {1}", row["PATIENTFIRSTNAME"], row["PATIENTLASTNAME"]);
                long InsuranceCode = Convert.ToInt64(row["INSURANCECODE"]);
                DateTime Date = Convert.ToDateTime(row["DATE"]);
                string DoctorName = Convert.ToString(row["DOCTORNAME"]);
                long Price = Convert.ToInt64(row["PRICE"]);
                result.Add(new PrescriptionListReportItemsBOL(PatientName, InsuranceCode, Date,DataConvertor.ConvertToPersianDate(Date), DoctorName, Price));
            }
            return result;
        }
        private static DataTable ExecuteReader(PrescriptionListReportFilterBOL _PrescriptionListReportBOL)
        {
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = selectPrescriptionListReport;
            sqlCommand.Parameters.Add("@InsuranceTypeId", SqlDbType.TinyInt).Value = ValidateParameter("@InsuranceTypeId", _PrescriptionListReportBOL.InsuranceTypeId, false);
            sqlCommand.Parameters.Add("@FromDate", SqlDbType.DateTime).Value = ValidateParameter("@FromDate", _PrescriptionListReportBOL.FromDate, false);
            sqlCommand.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = ValidateParameter("@ToDate", _PrescriptionListReportBOL.ToDate, false);
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