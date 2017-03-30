using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace ReUNITE
{
    public partial class MasterDetail : Form
    {
        private BindingSource masterBindingSource = new BindingSource();
        private BindingSource detailsBindingSource = new BindingSource();

        public MasterDetail()
        {
            InitializeComponent();


            DataSet nestedData = new DataSet();
            DataTable csvMainDataTable = ToDataTable<CsvMainData>(ParseMainCsvFile().ToList());
            DataTable csvChildDataTable = ToDataTable<CsvChildData>(ParseChildCsvFile().ToList());
            nestedData.Tables.Add(csvMainDataTable);
            nestedData.Tables[0].TableName = "Main";
            nestedData.Tables.Add(csvChildDataTable);
            DataRelation Datatablerelation = new DataRelation("ChildDetails", nestedData.Tables[0].Columns[0], nestedData.Tables[1].Columns[0], true);
            nestedData.Relations.Add(Datatablerelation);

            masterBindingSource.DataSource = nestedData;
            masterBindingSource.DataMember = "Main";
            detailsBindingSource.DataSource = masterBindingSource;
            detailsBindingSource.DataMember = "ChildDetails";


            masterDataGridView.DataSource = masterBindingSource;
            detailsDataGridView.DataSource = detailsBindingSource;
            masterDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            masterDataGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //masterDataGridView.AutoResizeColumns();
            //detailsDataGridView.AutoResizeColumns();

            masterDataGridView.Columns[0].Visible = false;
            detailsDataGridView.Columns[0].Visible = false;
            masterDataGridView.DataBindingComplete += DataGridViewMissingChildren_DataBindingComplete;
            masterDataGridView.CellMouseDown += DataGridViewMissingChildren_CellMouseDown;
            masterDataGridView.CellClick += DataGridViewMissingChildrenOnCellClick;

            //detailsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            //dataGridViewMissingChildren.AutoSizeColumnsMode =
            //DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void DataGridViewMissingChildren_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in masterDataGridView.Rows)
            {
                r.Cells["PosterUrl"] = new DataGridViewLinkCell();
            }
        }

        private void DataGridViewMissingChildrenOnCellClick(object sender, DataGridViewCellEventArgs dataGridViewCellEventArgs)
        {
            if (dataGridViewCellEventArgs.ColumnIndex == 5)
            {
                string posterURL =
                     masterDataGridView.Rows[dataGridViewCellEventArgs.RowIndex].Cells[
                         dataGridViewCellEventArgs.ColumnIndex].Value.ToString();

                //Search by Google Image Match
                //var imgUrlStr = "http://www.missingkids.org/photographs/NCMC600552c1.jpg";
                //var googleSearchUrl = "https://www.google.com/search?q=" + imgUrlStr + "&source=lnms&tbm=isch&*";
                //System.Diagnostics.Process.Start(googleSearchUrl);

                //Search by Google Web
                var missingKidName = "christopher abeyta";
                var googleUrl = "https://www.google.com/search?q=" + missingKidName;
                System.Diagnostics.Process.Start(googleUrl);

                missingKidName = "christopher abeyta";
                var twitterUrl = "https://twitter.com/search?q=" + missingKidName + "&src=typd";
                System.Diagnostics.Process.Start(twitterUrl);

                missingKidName = "christopher abeyta";
                var fbUrl = "https://facebook.com/search?q=" + missingKidName;
                System.Diagnostics.Process.Start(fbUrl);

                //var searchimagesURL = "http://www.google.com/images?q=NCMC600552c1.jpg";
                //System.Diagnostics.Process.Start(searchimagesURL);

                //var googleSearchUrl1 = "https://www.google.com/search?q=NCMC600552c1.jpg&source=lnms&tbm=isch&*";
                //System.Diagnostics.Process.Start(googleSearchUrl1);

                //WebViewer wv = new WebViewer(posterURL);
                //wv.ShowDialog(this);

            }
        }

        private void DataGridViewMissingChildren_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Ignore if a column or row header is clicked
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.Button == MouseButtons.Right)
                {
                    DataGridViewCell clickedCell = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex];

                    // Here you can do whatever you want with the cell
                    this.masterDataGridView.CurrentCell = clickedCell;  // Select the clicked cell, for instance

                    // Get mouse position relative to the vehicles grid
                    var relativeMousePosition = masterDataGridView.PointToClient(Cursor.Position);

                    // Show the context menu
                    this.contextMenuStrip1.Show(masterDataGridView, relativeMousePosition);
                }
            }
        }

        public static DataTable ToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }

        public class CsvMainData
        {
            public int ChildId { get; set; }
            public string ChildFirstName { get; set; }
            public string ChildLastName { get; set; }
            public DateTime MissingReportedDate { get; set; }
            public string PosterContact { get; set; }
            public string PosterUrl { get; set; }
        }

        public class CsvChildData
        {
            public int ChildId { get; set; }
            public DateTime BirthDate { get; set; }
            public string Sex { get; set; }
            public string Race { get; set; }
            public string Haircolor { get; set; }
            public string EyeColor { get; set; }
            public double Height { get; set; }
            public double Weight { get; set; }
            public DateTime MmissingFromdate { get; set; }
            public string MissingFromCity { get; set; }
            public string MissingFromState { get; set; }
            public string MissingFromCountry { get; set; }
            public string NcmecCaseNumber { get; set; }
            public string CaseType { get; set; }
            public string NcmecCaseManager { get; set; }

        }

        public IEnumerable<CsvMainData> ParseMainCsvFile()
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
                    yield return new CsvMainData()
                    {
                        ChildId = int.Parse(fields[0]),
                        ChildFirstName = fields[1],
                        ChildLastName = fields[2],
                        MissingReportedDate = DateTime.Parse(fields[10]),
                        PosterContact = fields[18],
                        PosterUrl = "http://" + fields[19]
                    };
                }

            }

        }


        public IEnumerable<CsvChildData> ParseChildCsvFile()
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
                    yield return new CsvChildData()
                    {
                        ChildId = int.Parse(fields[0]),
                        BirthDate = DateTime.Parse(fields[3]),
                        Sex = fields[4],
                        Race = fields[5],
                        Haircolor = fields[6],
                        EyeColor = fields[7],
                        Height = Double.Parse(fields[8]),
                        Weight = Double.Parse(fields[9]),
                        MmissingFromdate = DateTime.Parse(fields[11]),
                        MissingFromCity = fields[12],
                        MissingFromState = fields[13],
                        MissingFromCountry = fields[14],
                        NcmecCaseNumber = fields[15],
                        CaseType = fields[16],
                        NcmecCaseManager = fields[17]
                    };
                }

            }

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(searchTextBox.Text))
            {
                masterBindingSource.Filter = String.Format("ChildFirstName like '%{0}%' or ChildLastName like '%{0}%'",
                    searchTextBox.Text);
            }
            else
            {
                masterBindingSource.Filter = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.ShowDialog();
        }
    }
}

