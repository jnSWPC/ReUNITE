using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReUNITE
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            dataGridViewMissingChildren.DataSource = ParseCsvFile().ToList();
            dataGridViewMissingChildren.CellClick+= DataGridViewMissingChildrenOnCellClick;
        }

        private void DataGridViewMissingChildrenOnCellClick(object sender, DataGridViewCellEventArgs dataGridViewCellEventArgs)
        {
            if (dataGridViewCellEventArgs.ColumnIndex == 19)
            {
               string posterURL=
                    dataGridViewMissingChildren.Rows[dataGridViewCellEventArgs.RowIndex].Cells[
                        dataGridViewCellEventArgs.ColumnIndex].Value.ToString();

                WebViewer wv= new WebViewer(posterURL);
                wv.Show(this);

            }
        }


        public IEnumerable<CsvData> ParseCsvFile()
        {
            using (
                TextFieldParser parser =
                    new TextFieldParser(@"ActiveCases.csv")
            )
            {
                parser.CommentTokens = new string[] { "#" };
                parser.SetDelimiters(new string[] { "," });
                //parser.HasFieldsEnclosedInQuotes = true;

                // Skip over header line.
                parser.ReadLine();

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    yield return new CsvData()
                    {
                        ChildId = int.Parse(fields[0]),
                        ChildFirstName = fields[1],
                        ChildLastName = fields[2],
                        BirthDate = DateTime.Parse(fields[3]),
                        Sex = fields[4],
                        Race = fields[5],
                        Haircolor = fields[6],
                        EyeColor = fields[7],
                        Height = Double.Parse(fields[8]),
                        Weight = Double.Parse(fields[9]),
                        MissingReportedDate = DateTime.Parse(fields[10]),
                        MmissingFromdate = DateTime.Parse(fields[11]),
                        MissingFromCity = fields[12],
                        MissingFromState = fields[13],
                        MissingFromCountry = fields[14],
                        NcmecCaseNumber = fields[15],
                        CaseType = fields[16],
                        NcmecCaseManager = fields[17],
                        PosterContact = fields[18],
                        PosterUrl = fields[19]
                    };
                }

            }

        }
       
    }

    // Data Model
    public class CsvData
    {
        public int ChildId { get; set; }
        public string ChildFirstName { get; set; }
        public string ChildLastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Sex { get; set; }
        public string Race { get; set; }
        public string Haircolor { get; set; }
        public string EyeColor { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public DateTime MissingReportedDate { get; set; }
        public DateTime MmissingFromdate { get; set; }
        public string MissingFromCity { get; set; }
        public string MissingFromState { get; set; }
        public string MissingFromCountry { get; set; }
        public string NcmecCaseNumber { get; set; }
        public string CaseType { get; set; }
        public string NcmecCaseManager { get; set; }
        public string PosterContact { get; set; }
        public string PosterUrl { get; set; }
    }
}
