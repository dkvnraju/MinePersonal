using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Configuration;

namespace RassiCements_LTD
{
   public class PDFLocal
    {
        public void generatepdf(OleDbDataReader dr)
        {
           
            Document doc = new Document();
            PdfPTable pTable = new PdfPTable(5);

            PdfWriter.GetInstance(doc, new FileStream("c:\test.pdf", FileMode.Create));
            doc.Open();
            int rownumber = 0;
            while (dr.Read())
            {
                PdfPCell pheader = new PdfPCell(new Phrase("Rassi Cements LTD"));
                pheader.Border = 0;
                pheader.Colspan = 5;
                pTable.AddCell(pheader);


                if (rownumber == 0)
                {

                    DateTime dtm = Convert.ToDateTime(dr["Wagedate"].ToString());
                    pTable.AddCell(dtm.Month + "-" + dtm.Year);
                    pTable.AddCell(dr["EMPNAME"].ToString());
                    pTable.AddCell(dr["BATCHNO"].ToString());
                    pTable.AddCell("");
                    pTable.AddCell("");
                    // add line
                    PdfPCell pheader2 = new PdfPCell(new Phrase("-----------------------------------"));
                    pheader2.Border = 0;
                    pheader2.Colspan = 5;
                    pTable.AddCell(pheader);



                    //Insert col headings

                    pTable.AddCell("SlNo");
                    pTable.AddCell("Date");
                    pTable.AddCell("Shift");
                    pTable.AddCell("Amount");
                    pTable.AddCell("OB");
                }
                else
                {

                    pTable.AddCell(rownumber.ToString());
                    pTable.AddCell(dr["Wagedate"].ToString());
                    pTable.AddCell(dr["SHIFT"].ToString());
                    pTable.AddCell(dr["DAYAMOUNT"].ToString());
                    // need to find Other batch
                    string sql = "select BatchNo from EmployeeDetails where TokenNumber = " + Convert.ToUInt32(dr["TOKENNO"].ToString());
                    OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["RassiCements_LTD.Properties.Settings.RassiCementLTDConnectionString"].ConnectionString);
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand(sql, conn);
                    OleDbDataReader drt = cmd.ExecuteReader();

                    if (drt.HasRows)

                    {
                        if (drt["BatchNo"].ToString() == dr["Wagedate"].ToString())
                        {
                            pTable.AddCell("");
                        }
                        else
                        {
                            pTable.AddCell(drt["BatchNo"].ToString());
                        }

                    }

                }

                rownumber = rownumber + 1;

            }
            


            


           




            doc.Close();

            throw new NotImplementedException();
        }
    }
}
